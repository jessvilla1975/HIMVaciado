namespace InterfaceLlenadoAPP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonConectar = new System.Windows.Forms.Button();
            this.barra = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baudio = new System.Windows.Forms.ComboBox();
            this.puerto = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BotonStart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DatossRecibidos = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ledon = new System.Windows.Forms.PictureBox();
            this.ledoff = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.progressBarVertical1 = new InterfaceLlenadoAPP.ProgressBarVertical();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledoff)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.botonConectar);
            this.panel1.Controls.Add(this.barra);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.baudio);
            this.panel1.Controls.Add(this.puerto);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 531);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // botonConectar
            // 
            this.botonConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(76)))), ((int)(((byte)(204)))));
            this.botonConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonConectar.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConectar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.botonConectar.Location = new System.Drawing.Point(53, 164);
            this.botonConectar.Name = "botonConectar";
            this.botonConectar.Size = new System.Drawing.Size(95, 35);
            this.botonConectar.TabIndex = 3;
            this.botonConectar.Text = "Conectar";
            this.botonConectar.UseVisualStyleBackColor = false;
            this.botonConectar.Click += new System.EventHandler(this.button2_Click);
            // 
            // barra
            // 
            this.barra.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.barra.AnimationSpeed = 1000;
            this.barra.BackColor = System.Drawing.Color.Transparent;
            this.barra.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(76)))), ((int)(((byte)(204)))));
            this.barra.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.barra.InnerMargin = 2;
            this.barra.InnerWidth = -1;
            this.barra.Location = new System.Drawing.Point(32, 225);
            this.barra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 25);
            this.barra.MarqueeAnimationSpeed = 2000;
            this.barra.Name = "barra";
            this.barra.OuterColor = System.Drawing.Color.Black;
            this.barra.OuterMargin = -25;
            this.barra.OuterWidth = 26;
            this.barra.ProgressColor = System.Drawing.Color.LimeGreen;
            this.barra.ProgressWidth = 25;
            this.barra.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.barra.Size = new System.Drawing.Size(133, 131);
            this.barra.StartAngle = 270;
            this.barra.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.barra.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.barra.SubscriptText = "";
            this.barra.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.barra.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.barra.SuperscriptText = "";
            this.barra.TabIndex = 3;
            this.barra.Text = "0";
            this.barra.TextMargin = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.barra.Value = 50;
            this.barra.Click += new System.EventHandler(this.barra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conexión Puerto:";
            // 
            // baudio
            // 
            this.baudio.FormattingEnabled = true;
            this.baudio.Location = new System.Drawing.Point(32, 123);
            this.baudio.Name = "baudio";
            this.baudio.Size = new System.Drawing.Size(138, 21);
            this.baudio.TabIndex = 1;
            this.baudio.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // puerto
            // 
            this.puerto.FormattingEnabled = true;
            this.puerto.Location = new System.Drawing.Point(32, 47);
            this.puerto.Name = "puerto";
            this.puerto.Size = new System.Drawing.Size(138, 21);
            this.puerto.TabIndex = 0;
            this.puerto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(238, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 292);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(199, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gráfica del sensor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineWidth = 2;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.IndianRed;
            chartArea2.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            chartArea2.BackSecondaryColor = System.Drawing.Color.Linen;
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.CursorX.SelectionColor = System.Drawing.Color.White;
            chartArea2.CursorY.SelectionColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(17, 15);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Name = "Vaciado";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(478, 274);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title2.ForeColor = System.Drawing.Color.WhiteSmoke;
            title2.Name = "Flujo Caudal";
            this.chart1.Titles.Add(title2);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // BotonStart
            // 
            this.BotonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.BotonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonStart.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonStart.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BotonStart.Location = new System.Drawing.Point(17, 41);
            this.BotonStart.Name = "BotonStart";
            this.BotonStart.Size = new System.Drawing.Size(74, 44);
            this.BotonStart.TabIndex = 2;
            this.BotonStart.Text = "Start";
            this.BotonStart.UseVisualStyleBackColor = false;
            this.BotonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // serial
            // 
            this.serial.PortName = "COM8";
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.DatossRecibidos);
            this.panel3.Location = new System.Drawing.Point(770, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 531);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(64, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datos Sensor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DatossRecibidos
            // 
            this.DatossRecibidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(75)))));
            this.DatossRecibidos.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatossRecibidos.ForeColor = System.Drawing.SystemColors.Window;
            this.DatossRecibidos.Location = new System.Drawing.Point(16, 47);
            this.DatossRecibidos.Multiline = true;
            this.DatossRecibidos.Name = "DatossRecibidos";
            this.DatossRecibidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DatossRecibidos.Size = new System.Drawing.Size(184, 336);
            this.DatossRecibidos.TabIndex = 0;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.stop.Location = new System.Drawing.Point(109, 41);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(74, 44);
            this.stop.TabIndex = 5;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.ledon);
            this.panel4.Controls.Add(this.BotonStart);
            this.panel4.Controls.Add(this.ledoff);
            this.panel4.Controls.Add(this.stop);
            this.panel4.Location = new System.Drawing.Point(238, 310);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 233);
            this.panel4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(43, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Panel de Control";
            // 
            // ledon
            // 
            this.ledon.Image = global::InterfaceLlenadoAPP.Properties.Resources.VERDE;
            this.ledon.Location = new System.Drawing.Point(25, 90);
            this.ledon.Name = "ledon";
            this.ledon.Size = new System.Drawing.Size(57, 52);
            this.ledon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledon.TabIndex = 7;
            this.ledon.TabStop = false;
            // 
            // ledoff
            // 
            this.ledoff.Image = global::InterfaceLlenadoAPP.Properties.Resources.off;
            this.ledoff.Location = new System.Drawing.Point(117, 91);
            this.ledoff.Name = "ledoff";
            this.ledoff.Size = new System.Drawing.Size(57, 51);
            this.ledoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledoff.TabIndex = 6;
            this.ledoff.TabStop = false;
            this.ledoff.WaitOnLoad = true;
            this.ledoff.Click += new System.EventHandler(this.ledoff_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.progressBarVertical1);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(455, 310);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(297, 233);
            this.panel5.TabIndex = 9;
            // 
            // progressBarVertical1
            // 
            this.progressBarVertical1.Location = new System.Drawing.Point(112, 46);
            this.progressBarVertical1.MarqueeAnimationSpeed = 5000;
            this.progressBarVertical1.Name = "progressBarVertical1";
            this.progressBarVertical1.Size = new System.Drawing.Size(100, 174);
            this.progressBarVertical1.Step = 1;
            this.progressBarVertical1.TabIndex = 11;
            this.progressBarVertical1.Click += new System.EventHandler(this.progressBarVertical1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(100, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado tanque";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(56, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "1000 ml -";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(60, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "900 ml -";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(61, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "800 ml -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(62, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "700 ml -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(61, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "600 ml -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(61, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "500 ml -";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(61, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "400 ml -";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label14.Location = new System.Drawing.Point(62, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 19);
            this.label14.TabIndex = 20;
            this.label14.Text = "300 ml -";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label15.Location = new System.Drawing.Point(62, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "200 ml -";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(65, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 19);
            this.label16.TabIndex = 22;
            this.label16.Text = "100 ml -";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Location = new System.Drawing.Point(76, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 19);
            this.label17.TabIndex = 23;
            this.label17.Text = "0 ml -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(996, 555);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Name = "Form1";
            this.Text = "App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledoff)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox baudio;
        private System.Windows.Forms.ComboBox puerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularProgressBar.CircularProgressBar barra;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Button botonConectar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox DatossRecibidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox ledoff;
        private System.Windows.Forms.PictureBox ledon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private ProgressBarVertical progressBarVertical1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

