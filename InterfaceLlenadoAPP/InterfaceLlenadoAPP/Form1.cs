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

            String[] lista = SerialPort.GetPortNames();
            puerto.Items.AddRange(lista);
            chart1.Invoke((MethodInvoker)(() => chart1.Series["Vaciado"].Points.AddXY(0,0)));



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serial.PortName = puerto.Text;
                serial.BaudRate = Convert.ToInt32(baudio.Text);
                serial.Open();
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

        private void serial_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
          
            while (serial.IsOpen && serial.BytesToRead > 0)
            {
                string datos = serial.ReadLine();
           

                serial.ReadTimeout = 500;

                DatossRecibidos.Invoke(new MethodInvoker(
                
                    delegate
                    {
                        DatossRecibidos.Text += datos + "L/min" + Environment.NewLine;
                    }


                ));

                int value = Convert.ToInt32(datos);
                if(value >= progreso.Minimum && value <= progreso.Maximum)
                {
                    progreso.Invoke((MethodInvoker)(() => {
                        progreso.Value = value;
                        

                    }));

                }

                //chart1.Series["Analogo"].Points.AddY(value);
                chart1.Invoke((MethodInvoker)(() => chart1.Series["Vaciado"].Points.AddY(value)));





                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serial.PortName = puerto.Text;
                serial.BaudRate = Convert.ToInt32(baudio.Text);
                serial.Open();
                for(int i = 1; i <= 100; i++)
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

                serial.Close();
                chart1.Invoke((MethodInvoker)(() => chart1.Series["Vaciado"].Points.AddXY(0, 0)));




            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
