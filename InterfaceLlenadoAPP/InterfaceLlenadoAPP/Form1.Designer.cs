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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonConectar = new System.Windows.Forms.Button();
            this.barra = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baudio = new System.Windows.Forms.ComboBox();
            this.puerto = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BotonStart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DatossRecibidos = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.ledon = new System.Windows.Forms.PictureBox();
            this.ledoff = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledoff)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(200, 400);
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
            this.barra.Value = 68;
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
            this.panel2.Controls.Add(this.chart1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(238, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 292);
            this.panel2.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineWidth = 2;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.IndianRed;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            chartArea1.BackSecondaryColor = System.Drawing.Color.Linen;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.White;
            chartArea1.CursorY.SelectionColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(17, 15);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Name = "Vaciado";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(478, 274);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.ForeColor = System.Drawing.Color.WhiteSmoke;
            title1.Name = "Flujo Caudal";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // BotonStart
            // 
            this.BotonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(182)))), ((int)(((byte)(66)))));
            this.BotonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonStart.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonStart.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BotonStart.Location = new System.Drawing.Point(238, 324);
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
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(652, 345);
            this.progreso.Maximum = 1000;
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(100, 23);
            this.progreso.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.DatossRecibidos);
            this.panel3.Location = new System.Drawing.Point(770, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 400);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(45, 15);
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
            this.DatossRecibidos.Size = new System.Drawing.Size(165, 336);
            this.DatossRecibidos.TabIndex = 0;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.stop.Location = new System.Drawing.Point(330, 324);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(74, 44);
            this.stop.TabIndex = 5;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // ledon
            // 
            this.ledon.Image = global::InterfaceLlenadoAPP.Properties.Resources.VERDE;
            this.ledon.Location = new System.Drawing.Point(246, 373);
            this.ledon.Name = "ledon";
            this.ledon.Size = new System.Drawing.Size(57, 52);
            this.ledon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledon.TabIndex = 7;
            this.ledon.TabStop = false;
            // 
            // ledoff
            // 
            this.ledoff.Image = global::InterfaceLlenadoAPP.Properties.Resources.off;
            this.ledoff.Location = new System.Drawing.Point(338, 374);
            this.ledoff.Name = "ledoff";
            this.ledoff.Size = new System.Drawing.Size(57, 51);
            this.ledoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledoff.TabIndex = 6;
            this.ledoff.TabStop = false;
            this.ledoff.WaitOnLoad = true;
            this.ledoff.Click += new System.EventHandler(this.ledoff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.ledon);
            this.Controls.Add(this.ledoff);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.BotonStart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledoff)).EndInit();
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
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox DatossRecibidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox ledoff;
        private System.Windows.Forms.PictureBox ledon;
    }
}

