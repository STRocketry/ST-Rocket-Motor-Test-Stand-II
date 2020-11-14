using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using ST_Rocket_Motor_Test_Stand_II.Properties;

namespace ST_Rocket_Motor_Test_Stand_II
{
    public partial class Form1 : Form
    {
        int counter = 0;
        double ratio1 = 1;
        double ratio2 = 1;
        double startTime;
        long timeNow;
        double timeSec;

        bool start_stop = false;
        DateTime date1;
        
        long calibrationData = 0;
        string AxisYOperatingName;
        string AxisYCalibratingName = "Parrots";

        internal delegate void SerialDataReceivedEventHandlerDelegate(
                object sender, SerialDataReceivedEventArgs e);
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;
        string fullPath = String.Empty;

        double[] timeArray = new double[20000];
        int[] thrustArray = new int[20000];
        int thrustZero = 0;
        int lengthArray = 0;
        double timeSecZero;

        const double GRAV = 9.806651;

        public Form1()
        {
            InitializeComponent();

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            AxisYOperatingName = chart1.ChartAreas[0].AxisY.Title;
            SetAxis();

            List<LoadCell> loadCells = new List<LoadCell>();


            string path = Application.StartupPath.ToString() + "\\Load cells.txt";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ' });
                    loadCells.Add(new LoadCell { Name = words[0], A = words[1], B = words[2], Sign = words[3], Threshold = words[4] });
                }

            }

            LoadCellComboBox.DataSource = loadCells;
            LoadCellComboBox.DisplayMember = "Name";
            LoadCell loadCell = (LoadCell)LoadCellComboBox.SelectedItem;
            ratioBox.Text = loadCell.A;
            ratioBox2.Text = loadCell.B;
            thresholdNumericUpDown.Value = Convert.ToDecimal(loadCell.Threshold);
            labelSign.Text = loadCell.Sign;
            LoadCellComboBox.SelectedIndexChanged += LoadCellComboBox_SelectedIndexChanged;
            labelDateValue.Text = DateTime.Now.ToString("dd.MM.yyy");
        }

        private void SetAxis()
        {
            if (double.TryParse(axisXBox.Text, out double num))
            {
                chart1.ChartAreas[0].AxisX.Maximum = num;
            }
            else
            {
                chart1.ChartAreas[0].AxisX.Maximum = Double.NaN;
            }

            if (double.TryParse(axisYBox.Text, out num))
            {
                chart1.ChartAreas[0].AxisY.Maximum = num;
            }
            else
            {
                chart1.ChartAreas[0].AxisY.Maximum = Double.NaN;
            }
        }

        class LoadCell
        {
            public string Name { get; set; }
            public string A { get; set; }
            public string B { get; set; }
            public string Sign { get; set; }
            public string Threshold { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].Points.AddXY(0, 0);
            }
            catch
            {
                MessageBox.Show("Chart is not working :(");
            }
        }

        

        private void ArduinoButton_Click(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
            // Get a list of COM ports available in the system
            string[] portnames = SerialPort.GetPortNames();
            // Check whether there are available COM ports
            if (portnames.Length == 0)
            {
                MessageBox.Show("COM PORT not found");
            }
            foreach (string portName in portnames)
            {
                // Add available COM ports to the list           
                comboBox.Items.Add(portName);
                Console.WriteLine(portnames.Length);
                if (portnames[0] != null)
                {
                    comboBox.SelectedItem = portnames[0];
                }
                
            }
       }

        private void ConnectToArduino()
        {
            string selectedPort = comboBox.GetItemText(comboBox.SelectedItem);
            serialPort1.PortName = selectedPort;
            serialPort1.Open();
            connectButton.Text = "Disconnect";
            connectButton.BackColor = Color.DarkSlateBlue;
            connectButton.ForeColor = Color.White;
            OperatingRadioButton.Enabled = true;
            CalibratingRadioButton.Enabled = true;
        }

        private void DisconnectFromArduino()
        {
            SendCommandToArduino("0", 4, 50);
            serialPort1.Close();
            InputData = String.Empty;
            connectButton.Text = "Connect";
            connectButton.BackColor = SystemColors.Control;
            connectButton.ForeColor = SystemColors.ControlText;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SendCommandToArduino("0", 4, 50);
            // Close the port while closing the application
            if (serialPort1.IsOpen) serialPort1.Close();
        }


        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                ConnectToArduino();
            }
            else
            {
                DisconnectFromArduino();
            }
        }

        private void DataReceivedHandler(
                       object sender,
                       SerialDataReceivedEventArgs e)
        {
            RX.BackColor = Color.GreenYellow;
           // SetLedRX(this, true);

            //InputData = serialPort1.ReadExisting();
            InputData = serialPort1.ReadTo("\r\n");
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }

        private void SetText(string inputData)
        {
            textBox1.AppendText(Environment.NewLine + inputData);
            textBox1.ScrollToCaret();

            timeNow = GetTimeInMs();
            timeSec = (timeNow - startTime) / 1000;
            
            if (timeSec>= chart1.ChartAreas[0].AxisX.Maximum && chart1.ChartAreas[0].AxisX.Maximum != Double.NaN) 
            {
                chart1.ChartAreas[0].AxisX.Maximum = Double.NaN;
            }


            if (OperatingRadioButton.Checked)
            {
                int finalData = GetFinalData(inputData);
                thrustBox.Text = finalData.ToString();

                if (finalData >= chart1.ChartAreas[0].AxisY.Maximum && chart1.ChartAreas[0].AxisY.Maximum != Double.NaN)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = Double.NaN;
                }

                try
                {
                    chart1.Series[0].Points.AddXY(timeSec, finalData);
                }
                catch
                {
                    MessageBox.Show("Chart is not working :(");
                }


                CheckData(finalData);
                if (fullPath != String.Empty)
                {
                    WriteAsyncToLog(finalData.ToString(), fullPath, timeSec);
                }
                    
                
            }

            if (CalibratingRadioButton.Checked)
            {
                thrustBox.Text = inputData;

                if (!CalibrateButton.Enabled)
                {
                    counter++;
                    if (counter < 101)
                    {
                        calibrationData += int.Parse(inputData);

                    }
                    else
                    {
                        calibrationData /= 100;
                        if (fullPath != String.Empty)
                        {
                            CalibrationWriteAsync(textBoxInputGramms.Text, fullPath, calibrationData);
                        }
                        counter = 0;
                        CalibrateButton.Enabled = true;
                    }
                }

                try
                {
                   chart1.Series[0].Points.AddXY(timeSec, inputData);
                }
                catch
                {
                    MessageBox.Show("Chart is not working :(");
                }

                
            }

                RX.BackColor = Color.Gray;
               // SetLedRX(this, false);
        }

        private int GetFinalData (string inputData)
        {
            double finalData = int.Parse(inputData);
            
            if (labelSign.Text == "-")
            {
                finalData = (ratio1 * finalData) - ratio2;
            }
            if (labelSign.Text == "+")
            {
                finalData = (ratio1 * finalData) + ratio2;
            }
            if (finalData < 4) { finalData = 0; }            
                                                      
            return Convert.ToInt32(finalData);            
        }


        private void CheckData(int thrust)
        {
            
            if (thrust > thresholdNumericUpDown.Value && !start_stop)
            {
                start_stop = true;
                WriteToDataArrays(timeArray, thrustArray, counter, timeSecZero, thrustZero);
            }

            if (thrust > thresholdNumericUpDown.Value && start_stop)
            {
                counter++;
                WriteToDataArrays(timeArray, thrustArray, counter, timeSec, thrust);
                                
            }

            if (thrust <= thresholdNumericUpDown.Value && start_stop)
            {
                start_stop = false;
                counter++;
                WriteToDataArrays(timeArray, thrustArray, counter, timeSec, thrust);

                if (counter > 20)
                {
                    lengthArray = counter;
                    ResultCalculation(CalculateResultsInArrays(timeArray, thrustArray, lengthArray));
                }
                
                counter = 0;                
            }
            timeSecZero = timeSec;
            thrustZero = thrust;    
        }

        
        private void WriteToDataArrays(double[] timeArray, int[] thrustArray, int counter, double timeSec, int thrust)
        {
            timeArray[counter] = timeSec;
            thrustArray[counter] = thrust;
        }
        
        private double[] CalculateResultsInArrays(double[] timeArray, int[] thrustArray, int lengthArray)
        {
            double[] resultArray = new double[3] {0, 0, 0};

            resultArray[0] = timeArray[lengthArray] - timeArray[0];

            for (int i = 1; i <= lengthArray; i++)
            {
                
                resultArray[1] += (Convert.ToDouble(thrustArray[i]) + Convert.ToDouble(thrustArray[i - 1])) / 2 * (timeArray[i] - timeArray[i - 1]);
               // Console.WriteLine(resultArray[1]);
                
            }

            for (int i = 1; i < lengthArray; i++)
            { 
                if (thrustArray[i] > thrustArray[i + 1])
                {
                    thrustArray[i + 1] = thrustArray[i];
                    resultArray[2] = thrustArray[i];
                  // Console.WriteLine(resultArray[2]);
                }
                
            }

                return resultArray;
        }

        private static async void WriteAsyncToLog(string finalData, string writePath, double timeMs)
        {
          
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    string log = timeMs + "  " + finalData;
                    //string log = millisecs + "  " + finalData;
                    await sw.WriteLineAsync(log);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        static async void CalibrationWriteAsync(string InputGramms, string writePath, long calibrationData)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    string calibration = InputGramms + "  " + calibrationData;
                    
                    await sw.WriteLineAsync(calibration);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


/*        static async void SetLedRX(Form1 form, bool state)
        {
            form.pictureBoxLedRX.Visible = state;
            await Task.Run(async () =>
            {
               
                await Task.Delay(1);
            });
        }*/



        private void ButtonErase_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            thrustBox.Text = " ";
            counter = 0;

            try
            {
                chart1.Series[0].Points.AddXY(0, 0);
            }
            catch
            {
                MessageBox.Show("Chart is not working :(");
            }

            labelTimeValue.Text = "-";
            labelTotalImpulseValue.Text = "-";
            labelMaxThrustValue.Text = "-";
            labelSpecificImpulseValue.Text = "-";
            labelMotorClassValue.Text = "-";
            start_stop = false;           
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && InputData == String.Empty)
            {
                startTime = GetTimeInMs();
                counter = 0;
                CalibrateButton.Enabled = true;

                SetAxis();

                if (OperatingRadioButton.Checked)
                {
                    ratio1 = double.Parse(ratioBox.Text);
                    ratio2 = double.Parse(ratioBox2.Text);
                    CreateLogFile();
                    
                }

                if (CalibratingRadioButton.Checked)
                {
                    CreateCalibrationFile();
                }

               // pictureBoxLedRX.Visible = true;
                TX.BackColor = Color.Red;

                SendCommandToArduino("1", 4, 50);

                TX.BackColor = Color.Gray;
               // pictureBoxLedRX.Visible = false;

                OperatingRadioButton.Enabled = false;
                CalibratingRadioButton.Enabled = false;
            }
           
        }


        private void ButtonStop_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && InputData != String.Empty)
            {
                CalibrateButton.Enabled = true;

                RX.BackColor = Color.Gray;
                TX.BackColor = Color.Red;

                SendCommandToArduino("0", 4, 50);

                TX.BackColor = Color.Gray;
                InputData = String.Empty;

                if (CalibratingRadioButton.Checked) 
                { 
                    try 
                    {
                        using (StreamWriter sw = new StreamWriter(fullPath, true, System.Text.Encoding.Default))
                        {
                        
                                string calibration = "Calibration has been performed ;)";

                                sw.WriteLine(calibration);
                        }

                    }
                    catch (Exception x)
                    {
                        Console.WriteLine(x.Message);
                    }
                }
            }

            OperatingRadioButton.Enabled = true;
            CalibratingRadioButton.Enabled = true;            
        }


        private void SendCommandToArduino(string signal, int iteraton, int delayMs)
        {
            if (serialPort1.IsOpen)
            {
                for (int i = 1; i < iteraton; i++)
                {
                    serialPort1.Write(signal);
                    Thread.Sleep(delayMs);
                }
            }
        } 

        private void ResultCalculation (double[] resultArray)
        {
            double propellantMass = double.Parse(propellantMassTextBox.Text);

            double totalImpulse = resultArray[1] / 1000 * GRAV;
            double maxThrust = resultArray[2] / 1000 * GRAV;
            double specificImpulse = (totalImpulse / propellantMass) / GRAV;
            double averageThrust = totalImpulse / resultArray[0];

            string Time = Math.Round(resultArray[0], 3).ToString();
            string TotalImpulse = Math.Round(totalImpulse, 1).ToString();
            string MaxThrust = Math.Round(maxThrust, 1).ToString();
            string SpecificImpulse = Math.Round(specificImpulse, 1).ToString();

            ResultWriteToLog(fullPath, Time, TotalImpulse, MaxThrust, SpecificImpulse, GetMotorClass(totalImpulse, averageThrust));
            ResultWriteToLabels(Time, TotalImpulse, MaxThrust, SpecificImpulse, GetMotorClass(totalImpulse, averageThrust));

        }

        static void ResultWriteToLog (string writePath, string time, string totalImpulse, string maxThrust, string specificImpulse, string motorClass)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    string log = "\n" + "Time: " + time + " s" + "\n" 
                        + "Total Impulse: " + totalImpulse + " N*s"+ "\n"
                        + "Max Thrust: " + maxThrust + " N" + "\n"
                        + "Specific Impulse: " + specificImpulse + " s" + "\n"
                        + "Motor Class: " + motorClass + "\n";

                    sw.WriteLine(log);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void ResultWriteToLabels (string time, string totalImpulse, string maxThrust, string specificImpulse, string motorClass) 
        {
            labelTimeValue.Text = time;
            labelTotalImpulseValue.Text = totalImpulse;
            labelMaxThrustValue.Text = maxThrust;
            labelSpecificImpulseValue.Text = specificImpulse;
            labelMotorClassValue.Text = motorClass;
        }

        private string GetMotorClass(double totalImpulse, double averageThrust)
        {
            //string[,] MotorClass = new string[16, 3] {
            //   ///The data below is got from the https://en.wikipedia.org/wiki/Model_rocket_motor_classification
            //   {"Micro", "0", "0,3125"},
            //   {"1/4A", "0,3126", "0,625"},
            //   {"1/2A", "0,626", "1,25"},
            //   {"A", "1,26", "2,50"},
            //   {"B", "2,51", "5,00"},
            //   {"C", "5,01", "10,0"},
            //   {"D", "10,01", "20,0"},
            //   {"E", "20,01", "40,0"},
            //   {"F", "40,01", "80,0"},
            //   {"G", "80,01", "160"},
            //   {"H", "160,01", "320"},
            //   {"I", "320,01", "640"},
            //   {"J", "640,01", "1280"},
            //   {"K", "1280,01", "2560"},
            //   {"L", "2560,01", "5120"},
            //   {"M", "5120,01", "10240"}


            //};

            Dictionary<String, double> motors = new Dictionary<String, double>()
            {
                ///The data below is got from the https://en.wikipedia.org/wiki/Model_rocket_motor_classification
                { "Micro", 0.3125 },
                { "1/4A", 0.625 },
                { "1/2A", 1.25 },
                { "A", 2.5 },
                { "B", 5.0 },
                { "C", 10.0 },
                { "D", 20.0 },
                { "E", 40.0 },
                { "F", 80.0 },
                { "G", 160 },
                { "H", 320 },
                { "I", 640 },
                { "J", 1280 },
                { "K", 2560 },
                { "L", 5120 },
                { "M", 10240 }
            };

            double lowerLimit = 0.0;
            foreach (KeyValuePair<String, double> motor in motors)
            {
                double higherLimit = motor.Value;
                if (totalImpulse > lowerLimit && totalImpulse < higherLimit)
                {
                    int percent = (int)(totalImpulse / higherLimit * 100);
                    return String.Format("{0}{1} {2}%", motor.Key, (int)averageThrust, percent);
                }

                lowerLimit = higherLimit + 0.001;
            }

            // not found a suitable motor class
            return "Not found";


            //string motorClass = "--";
            //int percent = 0;

            //for (int i = 0; i < 15; i++)
            //{

            //    if (totalImpulse > double.Parse(MotorClass[i, 1]) && totalImpulse < double.Parse(MotorClass[i, 2]))
            //    {
            //        motorClass = MotorClass[i, 0];
            //        percent = Convert.ToInt32(totalImpulse / double.Parse(MotorClass[i, 2])*100);
            //        if (percent < 1) { percent = 0; }
            //    }

            //}

            //return motorClass + Convert.ToInt32(averageThrust).ToString() + " " + percent + "%";
        }

        private string ReplaceDate()
        {
            date1 = DateTime.Now;
            return date1.ToString("yyyyMMdd-HH-mm-ss");
        }

        private long GetTimeInMs()
        {
            date1 = DateTime.Now;
            int min = int.Parse(date1.ToString("mm"));
            int sec = int.Parse(date1.ToString("ss"));
            int ms = int.Parse(date1.ToString("fff"));
            return min *60 *1000 +sec*1000 + ms;
        }

        private void CreateLogFile()
        {
          string date = ReplaceDate();

          string fileName = date + ".log";
          fullPath = Application.StartupPath.ToString() + "\\logs\\"  + fileName;
          LoadCell loadCell = (LoadCell)LoadCellComboBox.SelectedItem;

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, false, System.Text.Encoding.Default))
                {
                    string log = "*Start log*" + "\n" + "Date: " + labelDateValue.Text + "\n" + "Test #" + testNumberTextBox.Text + "\n" + "Motor: " + motorTextBox.Text + "\n" + "Propellant mass, kg: " + propellantMassTextBox.Text + "\n" + "Load cell: " + loadCell.Name + "\n";
                    sw.WriteLine(log);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("The logs folder was not found. Create the folder and relaunch the application.");
            }
        }


        private void CreateCalibrationFile()
        {
            string date = ReplaceDate();
            LoadCell loadCell = (LoadCell)LoadCellComboBox.SelectedItem;
            
            string fileName = "Calibration " + loadCell.Name +" load cell "+ date + ".txt";

            fullPath = Application.StartupPath.ToString() + "\\" + fileName;

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath, false, System.Text.Encoding.Default))
                {
                    string calibration = "Start calibration load cell: " + loadCell.Name;
                    sw.WriteLine(calibration);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void LoadCellComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCell loadCell = (LoadCell)LoadCellComboBox.SelectedItem;
            ratioBox.Text = loadCell.A;
            ratioBox2.Text = loadCell.B;
            labelSign.Text = loadCell.Sign;
            thresholdNumericUpDown.Value = Convert.ToDecimal(loadCell.Threshold);
        }

        private void CalibratingRadioButton_CheckedChanged(Object sender,
                                         EventArgs e)
        {

            if (CalibratingRadioButton.Checked)
            {
                groupBoxCalibration.Visible = true;
                chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
                chart1.ChartAreas[0].AxisY.Title = AxisYCalibratingName;
                labelThrust.Text = AxisYCalibratingName;
            }
            else
            {
                groupBoxCalibration.Visible = false;
            }
        }

        private void OperatingRadioButton_CheckedChanged(Object sender,
                                        EventArgs e)
        {

            if (OperatingRadioButton.Checked)
            {
                groupBoxTestData.Visible = true;
                groupBoxResult.Visible = true;
                chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
                chart1.ChartAreas[0].AxisY.Title = AxisYOperatingName;
                labelThrust.Text = AxisYOperatingName;
            }
            else
            {
                groupBoxTestData.Visible = false;
                groupBoxResult.Visible = false;
            }
        }



        //Обработчик таймера (вызывается с заданной периодичностью)
        private void timer1_Tick_1(object sender, EventArgs e)
        {
                       
           // Console.WriteLine(counter);
            //DateTime now = DateTime.Now;
            //Console.WriteLine(now.ToString("mm:ss:ffff"));
          //  chart1.Series[0].Points.AddXY(counter, data);
            //  now = DateTime.Now;
            // Console.WriteLine(now.ToString("mm:ss:ffff"));
           
        }


        private void CalibrateButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && InputData != String.Empty)
            {
               CalibrateButton.Enabled = false;
            }
            
        }

        private void chart1_MouseWhatever(object sender, MouseEventArgs e)
        {

        }


    }
}


/*Possible improvements:
 * 1) Get Time - to use timer and threads
 * 2) Add new font - digits
 * 3) Displaying of mode's boxes
 * 4) Displaying point coordinates on the chart
*/