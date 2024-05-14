using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InterfaceLlenadoAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baudio.Text = "9600";
            barra.Value = 0;
            ledoff.Image = Properties.Resources.off;
            ledon.Image = Properties.Resources.VERDE;
            String[] lista = SerialPort.GetPortNames();
            puerto.Items.AddRange(lista);
            chart1.Invoke((MethodInvoker)(() => chart1.Series["Vaciado"].Points.AddXY(0,0)));
            progressBarVertical1.Value = 100;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int bandera = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                ledon.Image = Properties.Resources.green;
                ledoff.Image = Properties.Resources.off;
                serial.WriteLine("00");
                bandera = 1;
                chart1.Invoke((MethodInvoker)(() => {
                    chart1.Series["Vaciado"].Points.AddXY(0,0);
                }));
                progressBarVertical1.Invoke((MethodInvoker)(() => {
                    progressBarVertical1.Maximum = 100;
                    progressBarVertical1.Value = (int)(100);
                }));

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
        private int contador = 0;

        private void serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                while (serial.IsOpen && serial.BytesToRead > 0)
                {
                    if(bandera == 1)
                    {
                        contador++;
                    }
                    else
                    {
                        contador = 0;
                    }
                    string datos = serial.ReadLine();
                    
                    serial.ReadTimeout = 500;

                    DatossRecibidos.Invoke(new MethodInvoker(
                        delegate
                        {
                            DatossRecibidos.Text += datos + "V " + contador.ToString() +"s" + Environment.NewLine;
                        }
                    ));

                    


                    double value;
                    if (double.TryParse(datos, out value))
                    {
                        // Agregar el valor al gráfico
                        chart1.Invoke((MethodInvoker)(() => {
                            chart1.Series["Vaciado"].Points.AddXY(contador, value / 100);
                        }));

                        // Actualizar el valor del ProgressBarVertical
                        if(bandera == 1)
                        {
                            if (contador == 3)
                            {
                                
                                for (int i = 100; i >= 90; i--)
                                {
                                    int progressValue = i;
                                    
                                    progressBarVertical1.Invoke((MethodInvoker)(() =>
                                    {
                                        progressBarVertical1.Maximum = 100;
                                        progressBarVertical1.Value = progressValue;
                                        Thread.Sleep(150);

                                    }));
                                    
                                }
                            }
                            else if (contador == 6)
                            {
                                
                                for (int i = 90; i >= 80; i--)
                                {
                                    int progressValue = i;

                                    progressBarVertical1.Invoke((MethodInvoker)(() =>
                                    {
                                        progressBarVertical1.Maximum = 100;
                                        progressBarVertical1.Value = progressValue;
                                        Thread.Sleep(150);
                                    }));
                                    
                                }
                            }
                            else if (contador == 8)
                            {
                                
                                for (int i = 80; i >= 70; i--)
                                {
                                    int progressValue = i;

                                    progressBarVertical1.Invoke((MethodInvoker)(() =>
                                    {
                                        progressBarVertical1.Maximum = 100;
                                        progressBarVertical1.Value = progressValue;
                                        Thread.Sleep(150);
                                    }));

                                }
                            }
                            else if (contador == 11)
                            {
                                
                                
                                for (int i = 70; i >= 60; i--)
                                {
                                    int progressValue = i;

                                    progressBarVertical1.Invoke((MethodInvoker)(() =>
                                    {
                                        progressBarVertical1.Maximum = 100;
                                        progressBarVertical1.Value = progressValue;
                                        Thread.Sleep(150);
                                    }));

                                }
                            }
                            else if (contador == 14)
                            {
                                serial.WriteLine("11111");
                                for (int i = 60; i >= 50; i--)
                                {
                                    int progressValue = i;

                                    progressBarVertical1.Invoke((MethodInvoker)(() =>
                                    {
                                        progressBarVertical1.Maximum = 100;
                                        progressBarVertical1.Value = progressValue;
                                        Thread.Sleep(150);
                                    }));

                                }
                            }

                        }
                        else
                        {
                            progressBarVertical1.Invoke((MethodInvoker)(() => {
                                progressBarVertical1.Maximum = 100;
                                progressBarVertical1.Value = (int)(100);
                            }));
                        }
                    }
                    else
                    {
                    
                        MessageBox.Show("No se pudo convertir los datos a un número.");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serial.PortName = puerto.Text;
                serial.BaudRate = Convert.ToInt32(baudio.Text);
                serial.Open();
                ledon.Image = Properties.Resources.green;

                for (int i = 1; i <= 100; i++)
                {
                    barra.Value = i;
                    barra.Text = i.ToString();
                    
                }


            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void barra_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            try
            {
                serial.WriteLine("11111");
                serial.Close();
                chart1.Invoke((MethodInvoker)(() => chart1.Series["Vaciado"].Points.AddXY(0, 0)));
                ledoff.Image = Properties.Resources.on;
                ledon.Image = Properties.Resources.VERDE;




            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ledoff_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progreso_Click(object sender, EventArgs e)
        {

        }

        private void progressBarVertical1_Click(object sender, EventArgs e)
        {

        }

        private void progressBarVertical1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
