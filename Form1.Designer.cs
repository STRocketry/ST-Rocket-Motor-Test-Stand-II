namespace ST_Rocket_Motor_Test_Stand_II
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ratioBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ArduinoButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RX = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelThrust = new System.Windows.Forms.Label();
            this.thrustBox = new System.Windows.Forms.TextBox();
            this.TX = new System.Windows.Forms.Label();
            this.groupBoxLoadCell = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSign = new System.Windows.Forms.Label();
            this.thresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ratioBox2 = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.LoadCellComboBox = new System.Windows.Forms.ComboBox();
            this.Y = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelTimeValue = new System.Windows.Forms.Label();
            this.labelMotorClassValue = new System.Windows.Forms.Label();
            this.labelSpecificImpulseValue = new System.Windows.Forms.Label();
            this.labelTotalImpulseValue = new System.Windows.Forms.Label();
            this.labelMotorClass = new System.Windows.Forms.Label();
            this.labelSpecificImpulse = new System.Windows.Forms.Label();
            this.labelMaxThrustValue = new System.Windows.Forms.Label();
            this.labelMaxThrust = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.testNumberTextBox = new System.Windows.Forms.TextBox();
            this.OperatingRadioButton = new System.Windows.Forms.RadioButton();
            this.CalibratingRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.CalibrateButton = new System.Windows.Forms.Button();
            this.groupBoxCalibration = new System.Windows.Forms.GroupBox();
            this.textBoxInputGramms = new System.Windows.Forms.TextBox();
            this.groupBoxTestData = new System.Windows.Forms.GroupBox();
            this.labelDateValue = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPropellantMass = new System.Windows.Forms.Label();
            this.propellantMassTextBox = new System.Windows.Forms.TextBox();
            this.labelMotor = new System.Windows.Forms.Label();
            this.motorTextBox = new System.Windows.Forms.TextBox();
            this.labelTestNumber = new System.Windows.Forms.Label();
            this.axisXBox = new System.Windows.Forms.TextBox();
            this.axisYBox = new System.Windows.Forms.TextBox();
            this.groupBoxAxis = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxLedRX = new System.Windows.Forms.PictureBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBoxLoadCell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.groupBoxCalibration.SuspendLayout();
            this.groupBoxTestData.SuspendLayout();
            this.groupBoxAxis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLedRX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ratioBox
            // 
            this.ratioBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ratioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratioBox.Location = new System.Drawing.Point(39, 52);
            this.ratioBox.Name = "ratioBox";
            this.ratioBox.Size = new System.Drawing.Size(45, 20);
            this.ratioBox.TabIndex = 11;
            this.ratioBox.Text = "0,009";
            this.ratioBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // ArduinoButton
            // 
            this.ArduinoButton.Location = new System.Drawing.Point(12, 12);
            this.ArduinoButton.Name = "ArduinoButton";
            this.ArduinoButton.Size = new System.Drawing.Size(90, 23);
            this.ArduinoButton.TabIndex = 0;
            this.ArduinoButton.Text = "Get COM-port";
            this.ArduinoButton.UseVisualStyleBackColor = true;
            this.ArduinoButton.Click += new System.EventHandler(this.ArduinoButton_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 50);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(90, 21);
            this.comboBox.TabIndex = 1;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.Control;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.connectButton.Location = new System.Drawing.Point(12, 86);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(90, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Location = new System.Drawing.Point(12, 158);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(88, 60);
            this.textBox1.TabIndex = 3;
            // 
            // RX
            // 
            this.RX.AutoSize = true;
            this.RX.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RX.Location = new System.Drawing.Point(74, 135);
            this.RX.Name = "RX";
            this.RX.Size = new System.Drawing.Size(26, 15);
            this.RX.TabIndex = 4;
            this.RX.Text = "RX";
            this.RX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea1.AxisX.Title = "Time (sec.)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Thrust (gram)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.DataSource = this.form1BindingSource;
            this.chart1.Location = new System.Drawing.Point(124, 135);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(652, 278);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 314);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(89, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(12, 390);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(88, 23);
            this.buttonErase.TabIndex = 7;
            this.buttonErase.Text = "Erase";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.ButtonErase_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(12, 352);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(88, 23);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // labelThrust
            // 
            this.labelThrust.AutoSize = true;
            this.labelThrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThrust.Location = new System.Drawing.Point(121, 108);
            this.labelThrust.Name = "labelThrust";
            this.labelThrust.Size = new System.Drawing.Size(93, 17);
            this.labelThrust.TabIndex = 9;
            this.labelThrust.Text = "Thrust, gram:";
            this.labelThrust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thrustBox
            // 
            this.thrustBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.thrustBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thrustBox.Location = new System.Drawing.Point(223, 102);
            this.thrustBox.Name = "thrustBox";
            this.thrustBox.ReadOnly = true;
            this.thrustBox.Size = new System.Drawing.Size(75, 26);
            this.thrustBox.TabIndex = 10;
            this.thrustBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TX
            // 
            this.TX.AutoSize = true;
            this.TX.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TX.Location = new System.Drawing.Point(12, 135);
            this.TX.Name = "TX";
            this.TX.Size = new System.Drawing.Size(25, 15);
            this.TX.TabIndex = 12;
            this.TX.Text = "TX";
            this.TX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxLoadCell
            // 
            this.groupBoxLoadCell.Controls.Add(this.label5);
            this.groupBoxLoadCell.Controls.Add(this.labelSign);
            this.groupBoxLoadCell.Controls.Add(this.thresholdNumericUpDown);
            this.groupBoxLoadCell.Controls.Add(this.ratioBox2);
            this.groupBoxLoadCell.Controls.Add(this.X);
            this.groupBoxLoadCell.Controls.Add(this.LoadCellComboBox);
            this.groupBoxLoadCell.Controls.Add(this.Y);
            this.groupBoxLoadCell.Controls.Add(this.ratioBox);
            this.groupBoxLoadCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxLoadCell.Location = new System.Drawing.Point(123, 12);
            this.groupBoxLoadCell.Name = "groupBoxLoadCell";
            this.groupBoxLoadCell.Size = new System.Drawing.Size(175, 80);
            this.groupBoxLoadCell.TabIndex = 13;
            this.groupBoxLoadCell.TabStop = false;
            this.groupBoxLoadCell.Text = "Load Cell";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(68, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Threshold";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSign
            // 
            this.labelSign.AutoSize = true;
            this.labelSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSign.Location = new System.Drawing.Point(105, 56);
            this.labelSign.Name = "labelSign";
            this.labelSign.Size = new System.Drawing.Size(11, 13);
            this.labelSign.TabIndex = 18;
            this.labelSign.Text = "-";
            // 
            // thresholdNumericUpDown
            // 
            this.thresholdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thresholdNumericUpDown.Location = new System.Drawing.Point(120, 25);
            this.thresholdNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.thresholdNumericUpDown.Name = "thresholdNumericUpDown";
            this.thresholdNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.thresholdNumericUpDown.TabIndex = 17;
            this.thresholdNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ratioBox2
            // 
            this.ratioBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratioBox2.Location = new System.Drawing.Point(120, 53);
            this.ratioBox2.Name = "ratioBox2";
            this.ratioBox2.Size = new System.Drawing.Size(48, 20);
            this.ratioBox2.TabIndex = 14;
            this.ratioBox2.Text = "0,8436";
            this.ratioBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(85, 54);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(26, 17);
            this.X.TabIndex = 13;
            this.X.Text = "* X";
            // 
            // LoadCellComboBox
            // 
            this.LoadCellComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadCellComboBox.Location = new System.Drawing.Point(12, 25);
            this.LoadCellComboBox.Name = "LoadCellComboBox";
            this.LoadCellComboBox.Size = new System.Drawing.Size(53, 21);
            this.LoadCellComboBox.TabIndex = 16;
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(10, 54);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(29, 17);
            this.Y.TabIndex = 12;
            this.Y.Text = "Y =";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxResult.Controls.Add(this.labelTimeValue);
            this.groupBoxResult.Controls.Add(this.labelMotorClassValue);
            this.groupBoxResult.Controls.Add(this.labelSpecificImpulseValue);
            this.groupBoxResult.Controls.Add(this.labelTotalImpulseValue);
            this.groupBoxResult.Controls.Add(this.labelMotorClass);
            this.groupBoxResult.Controls.Add(this.labelSpecificImpulse);
            this.groupBoxResult.Controls.Add(this.labelMaxThrustValue);
            this.groupBoxResult.Controls.Add(this.labelMaxThrust);
            this.groupBoxResult.Controls.Add(this.label2);
            this.groupBoxResult.Controls.Add(this.label1);
            this.groupBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult.Location = new System.Drawing.Point(431, 12);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(181, 117);
            this.groupBoxResult.TabIndex = 14;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // labelTimeValue
            // 
            this.labelTimeValue.AutoSize = true;
            this.labelTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeValue.Location = new System.Drawing.Point(111, 22);
            this.labelTimeValue.Name = "labelTimeValue";
            this.labelTimeValue.Size = new System.Drawing.Size(11, 13);
            this.labelTimeValue.TabIndex = 11;
            this.labelTimeValue.Text = "-";
            this.labelTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMotorClassValue
            // 
            this.labelMotorClassValue.AutoSize = true;
            this.labelMotorClassValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMotorClassValue.Location = new System.Drawing.Point(111, 98);
            this.labelMotorClassValue.Name = "labelMotorClassValue";
            this.labelMotorClassValue.Size = new System.Drawing.Size(11, 13);
            this.labelMotorClassValue.TabIndex = 10;
            this.labelMotorClassValue.Text = "-";
            this.labelMotorClassValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSpecificImpulseValue
            // 
            this.labelSpecificImpulseValue.AutoSize = true;
            this.labelSpecificImpulseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecificImpulseValue.Location = new System.Drawing.Point(111, 79);
            this.labelSpecificImpulseValue.Name = "labelSpecificImpulseValue";
            this.labelSpecificImpulseValue.Size = new System.Drawing.Size(11, 13);
            this.labelSpecificImpulseValue.TabIndex = 9;
            this.labelSpecificImpulseValue.Text = "-";
            this.labelSpecificImpulseValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalImpulseValue
            // 
            this.labelTotalImpulseValue.AutoSize = true;
            this.labelTotalImpulseValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalImpulseValue.Location = new System.Drawing.Point(111, 43);
            this.labelTotalImpulseValue.Name = "labelTotalImpulseValue";
            this.labelTotalImpulseValue.Size = new System.Drawing.Size(11, 13);
            this.labelTotalImpulseValue.TabIndex = 8;
            this.labelTotalImpulseValue.Text = "-";
            this.labelTotalImpulseValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMotorClass
            // 
            this.labelMotorClass.AutoSize = true;
            this.labelMotorClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMotorClass.Location = new System.Drawing.Point(6, 98);
            this.labelMotorClass.Name = "labelMotorClass";
            this.labelMotorClass.Size = new System.Drawing.Size(65, 13);
            this.labelMotorClass.TabIndex = 7;
            this.labelMotorClass.Text = "Motor Class:";
            // 
            // labelSpecificImpulse
            // 
            this.labelSpecificImpulse.AutoSize = true;
            this.labelSpecificImpulse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpecificImpulse.Location = new System.Drawing.Point(6, 79);
            this.labelSpecificImpulse.Name = "labelSpecificImpulse";
            this.labelSpecificImpulse.Size = new System.Drawing.Size(110, 13);
            this.labelSpecificImpulse.TabIndex = 6;
            this.labelSpecificImpulse.Text = "Specific Impulse, sec:";
            // 
            // labelMaxThrustValue
            // 
            this.labelMaxThrustValue.AutoSize = true;
            this.labelMaxThrustValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxThrustValue.Location = new System.Drawing.Point(111, 60);
            this.labelMaxThrustValue.Name = "labelMaxThrustValue";
            this.labelMaxThrustValue.Size = new System.Drawing.Size(11, 13);
            this.labelMaxThrustValue.TabIndex = 5;
            this.labelMaxThrustValue.Text = "-";
            this.labelMaxThrustValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMaxThrust
            // 
            this.labelMaxThrust.AutoSize = true;
            this.labelMaxThrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxThrust.Location = new System.Drawing.Point(6, 60);
            this.labelMaxThrust.Name = "labelMaxThrust";
            this.labelMaxThrust.Size = new System.Drawing.Size(77, 13);
            this.labelMaxThrust.TabIndex = 4;
            this.labelMaxThrust.Text = "Max Thrust, N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Impulse, N-sec:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time, sec:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testNumberTextBox
            // 
            this.testNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testNumberTextBox.Location = new System.Drawing.Point(68, 34);
            this.testNumberTextBox.Name = "testNumberTextBox";
            this.testNumberTextBox.Size = new System.Drawing.Size(47, 20);
            this.testNumberTextBox.TabIndex = 15;
            this.testNumberTextBox.Text = "1";
            this.testNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OperatingRadioButton
            // 
            this.OperatingRadioButton.AutoSize = true;
            this.OperatingRadioButton.Checked = true;
            this.OperatingRadioButton.Location = new System.Drawing.Point(6, 19);
            this.OperatingRadioButton.Name = "OperatingRadioButton";
            this.OperatingRadioButton.Size = new System.Drawing.Size(71, 17);
            this.OperatingRadioButton.TabIndex = 17;
            this.OperatingRadioButton.TabStop = true;
            this.OperatingRadioButton.Text = "Operating";
            this.OperatingRadioButton.UseVisualStyleBackColor = true;
            this.OperatingRadioButton.CheckedChanged += new System.EventHandler(this.OperatingRadioButton_CheckedChanged);
            // 
            // CalibratingRadioButton
            // 
            this.CalibratingRadioButton.AutoSize = true;
            this.CalibratingRadioButton.Location = new System.Drawing.Point(6, 42);
            this.CalibratingRadioButton.Name = "CalibratingRadioButton";
            this.CalibratingRadioButton.Size = new System.Drawing.Size(74, 17);
            this.CalibratingRadioButton.TabIndex = 18;
            this.CalibratingRadioButton.Text = "Calibrating";
            this.CalibratingRadioButton.UseVisualStyleBackColor = true;
            this.CalibratingRadioButton.CheckedChanged += new System.EventHandler(this.CalibratingRadioButton_CheckedChanged);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.OperatingRadioButton);
            this.groupBoxMode.Controls.Add(this.CalibratingRadioButton);
            this.groupBoxMode.Location = new System.Drawing.Point(12, 229);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(89, 74);
            this.groupBoxMode.TabIndex = 19;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // CalibrateButton
            // 
            this.CalibrateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalibrateButton.Location = new System.Drawing.Point(75, 24);
            this.CalibrateButton.Name = "CalibrateButton";
            this.CalibrateButton.Size = new System.Drawing.Size(75, 23);
            this.CalibrateButton.TabIndex = 20;
            this.CalibrateButton.Text = "Calibrate";
            this.CalibrateButton.UseVisualStyleBackColor = true;
            this.CalibrateButton.Click += new System.EventHandler(this.CalibrateButton_Click);
            // 
            // groupBoxCalibration
            // 
            this.groupBoxCalibration.Controls.Add(this.textBoxInputGramms);
            this.groupBoxCalibration.Controls.Add(this.CalibrateButton);
            this.groupBoxCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCalibration.Location = new System.Drawing.Point(618, 12);
            this.groupBoxCalibration.Name = "groupBoxCalibration";
            this.groupBoxCalibration.Size = new System.Drawing.Size(158, 59);
            this.groupBoxCalibration.TabIndex = 21;
            this.groupBoxCalibration.TabStop = false;
            this.groupBoxCalibration.Text = "Calibration";
            this.groupBoxCalibration.Visible = false;
            // 
            // textBoxInputGramms
            // 
            this.textBoxInputGramms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.253F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputGramms.Location = new System.Drawing.Point(8, 25);
            this.textBoxInputGramms.Name = "textBoxInputGramms";
            this.textBoxInputGramms.Size = new System.Drawing.Size(59, 20);
            this.textBoxInputGramms.TabIndex = 21;
            this.textBoxInputGramms.Text = "1";
            this.textBoxInputGramms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxTestData
            // 
            this.groupBoxTestData.Controls.Add(this.labelDateValue);
            this.groupBoxTestData.Controls.Add(this.labelDate);
            this.groupBoxTestData.Controls.Add(this.labelPropellantMass);
            this.groupBoxTestData.Controls.Add(this.propellantMassTextBox);
            this.groupBoxTestData.Controls.Add(this.labelMotor);
            this.groupBoxTestData.Controls.Add(this.motorTextBox);
            this.groupBoxTestData.Controls.Add(this.labelTestNumber);
            this.groupBoxTestData.Controls.Add(this.testNumberTextBox);
            this.groupBoxTestData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTestData.Location = new System.Drawing.Point(304, 12);
            this.groupBoxTestData.Name = "groupBoxTestData";
            this.groupBoxTestData.Size = new System.Drawing.Size(121, 117);
            this.groupBoxTestData.TabIndex = 22;
            this.groupBoxTestData.TabStop = false;
            this.groupBoxTestData.Text = "Test Data";
            // 
            // labelDateValue
            // 
            this.labelDateValue.AutoSize = true;
            this.labelDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateValue.Location = new System.Drawing.Point(58, 18);
            this.labelDateValue.Name = "labelDateValue";
            this.labelDateValue.Size = new System.Drawing.Size(10, 13);
            this.labelDateValue.TabIndex = 22;
            this.labelDateValue.Text = "-";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(12, 19);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Date:";
            // 
            // labelPropellantMass
            // 
            this.labelPropellantMass.AutoSize = true;
            this.labelPropellantMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPropellantMass.Location = new System.Drawing.Point(11, 84);
            this.labelPropellantMass.Name = "labelPropellantMass";
            this.labelPropellantMass.Size = new System.Drawing.Size(57, 26);
            this.labelPropellantMass.TabIndex = 20;
            this.labelPropellantMass.Text = "Propellant \r\nmass, kg";
            // 
            // propellantMassTextBox
            // 
            this.propellantMassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.propellantMassTextBox.Location = new System.Drawing.Point(68, 90);
            this.propellantMassTextBox.Name = "propellantMassTextBox";
            this.propellantMassTextBox.Size = new System.Drawing.Size(47, 20);
            this.propellantMassTextBox.TabIndex = 19;
            this.propellantMassTextBox.Text = "0,3";
            this.propellantMassTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMotor
            // 
            this.labelMotor.AutoSize = true;
            this.labelMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMotor.Location = new System.Drawing.Point(11, 63);
            this.labelMotor.Name = "labelMotor";
            this.labelMotor.Size = new System.Drawing.Size(34, 13);
            this.labelMotor.TabIndex = 18;
            this.labelMotor.Text = "Motor";
            // 
            // motorTextBox
            // 
            this.motorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.motorTextBox.Location = new System.Drawing.Point(51, 60);
            this.motorTextBox.Name = "motorTextBox";
            this.motorTextBox.Size = new System.Drawing.Size(64, 20);
            this.motorTextBox.TabIndex = 17;
            this.motorTextBox.Text = "ST36";
            this.motorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTestNumber
            // 
            this.labelTestNumber.AutoSize = true;
            this.labelTestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTestNumber.Location = new System.Drawing.Point(11, 38);
            this.labelTestNumber.Name = "labelTestNumber";
            this.labelTestNumber.Size = new System.Drawing.Size(38, 13);
            this.labelTestNumber.TabIndex = 16;
            this.labelTestNumber.Text = "Test #";
            // 
            // axisXBox
            // 
            this.axisXBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.253F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.axisXBox.Location = new System.Drawing.Point(26, 26);
            this.axisXBox.Name = "axisXBox";
            this.axisXBox.Size = new System.Drawing.Size(39, 20);
            this.axisXBox.TabIndex = 23;
            this.axisXBox.Text = "Auto";
            this.axisXBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // axisYBox
            // 
            this.axisYBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.253F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.axisYBox.Location = new System.Drawing.Point(96, 25);
            this.axisYBox.Name = "axisYBox";
            this.axisYBox.Size = new System.Drawing.Size(54, 20);
            this.axisYBox.TabIndex = 24;
            this.axisYBox.Text = "Auto";
            this.axisYBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxAxis
            // 
            this.groupBoxAxis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAxis.Controls.Add(this.label4);
            this.groupBoxAxis.Controls.Add(this.label3);
            this.groupBoxAxis.Controls.Add(this.axisXBox);
            this.groupBoxAxis.Controls.Add(this.axisYBox);
            this.groupBoxAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAxis.Location = new System.Drawing.Point(618, 77);
            this.groupBoxAxis.Name = "groupBoxAxis";
            this.groupBoxAxis.Size = new System.Drawing.Size(158, 52);
            this.groupBoxAxis.TabIndex = 25;
            this.groupBoxAxis.TabStop = false;
            this.groupBoxAxis.Text = "Axis Maximum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(76, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "X:";
            // 
            // pictureBoxLedRX
            // 
            this.pictureBoxLedRX.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLedRX.Image")));
            this.pictureBoxLedRX.Location = new System.Drawing.Point(48, 132);
            this.pictureBoxLedRX.Name = "pictureBoxLedRX";
            this.pictureBoxLedRX.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxLedRX.TabIndex = 26;
            this.pictureBoxLedRX.TabStop = false;
            this.pictureBoxLedRX.Visible = false;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(ST_Rocket_Motor_Test_Stand_II.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.pictureBoxLedRX);
            this.Controls.Add(this.groupBoxAxis);
            this.Controls.Add(this.groupBoxTestData);
            this.Controls.Add(this.groupBoxCalibration);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.groupBoxLoadCell);
            this.Controls.Add(this.TX);
            this.Controls.Add(this.thrustBox);
            this.Controls.Add(this.labelThrust);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.RX);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.ArduinoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ST Rocket Motor Test Stand II";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBoxLoadCell.ResumeLayout(false);
            this.groupBoxLoadCell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericUpDown)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.groupBoxCalibration.ResumeLayout(false);
            this.groupBoxCalibration.PerformLayout();
            this.groupBoxTestData.ResumeLayout(false);
            this.groupBoxTestData.PerformLayout();
            this.groupBoxAxis.ResumeLayout(false);
            this.groupBoxAxis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLedRX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ArduinoButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button connectButton;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelThrust;
        private System.Windows.Forms.TextBox thrustBox;
        private System.Windows.Forms.TextBox ratioBox;
        private System.Windows.Forms.Label TX;
        private System.Windows.Forms.GroupBox groupBoxLoadCell;
        private System.Windows.Forms.TextBox ratioBox2;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox testNumberTextBox;
        private System.Windows.Forms.ComboBox LoadCellComboBox;
        private System.Windows.Forms.RadioButton OperatingRadioButton;
        private System.Windows.Forms.RadioButton CalibratingRadioButton;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.Button CalibrateButton;
        private System.Windows.Forms.GroupBox groupBoxCalibration;
        private System.Windows.Forms.TextBox textBoxInputGramms;
        private System.Windows.Forms.GroupBox groupBoxTestData;
        private System.Windows.Forms.Label labelTestNumber;
        private System.Windows.Forms.Label labelMotor;
        private System.Windows.Forms.TextBox motorTextBox;
        private System.Windows.Forms.Label labelPropellantMass;
        private System.Windows.Forms.TextBox propellantMassTextBox;
        private System.Windows.Forms.Label labelMaxThrustValue;
        private System.Windows.Forms.Label labelMaxThrust;
        private System.Windows.Forms.Label labelSpecificImpulse;
        private System.Windows.Forms.Label labelTimeValue;
        private System.Windows.Forms.Label labelMotorClassValue;
        private System.Windows.Forms.Label labelSpecificImpulseValue;
        private System.Windows.Forms.Label labelTotalImpulseValue;
        private System.Windows.Forms.Label labelMotorClass;
        private System.Windows.Forms.Label labelDateValue;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.NumericUpDown thresholdNumericUpDown;
        private System.Windows.Forms.Label labelSign;
        private System.Windows.Forms.TextBox axisXBox;
        private System.Windows.Forms.TextBox axisYBox;
        private System.Windows.Forms.GroupBox groupBoxAxis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxLedRX;
    }
}

