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

namespace Product_Quality_Checker_System
{
    public partial class f : Form
    {
        SerialPort arduinoPort;
        public f()
        {
            InitializeComponent();
            arduinoPort = new SerialPort("COM8", 9600);//ajust com port
            arduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            arduinoPort.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }



        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = arduinoPort.ReadLine().Trim(); // Read and trim the data
            this.Invoke(new Action(() =>
            {
                UpdateData(data);
                outputTextBox.Clear();
                if (data == "Red Color" || data == "Blue Color" || data == "Green Color" || data == "Defective Product" || data == "Counters reset")
                {
                    outputTextBox.AppendText(data + Environment.NewLine);
                }
            }));

            /*string data = arduinoPort.ReadLine();
            this.Invoke(new Action(() => UpdateData(data)));
            this.Invoke(new MethodInvoker(delegate
            {
                outputTextBox.AppendText(data + "\n");
            }));*/
        }

        // Update text boxes based on Arduino data
        private void UpdateData(string data)
        {
            if (data.StartsWith("Red Count:"))
                redcount.Text = data.Split(':')[1].Trim();
            else if (data.StartsWith("Green Count:"))
                greencount.Text = data.Split(':')[1].Trim();
            else if (data.StartsWith("Blue Count:"))
                bluecount.Text = data.Split(':')[1].Trim();
            else if (data.StartsWith("Good Total Count:"))
                goodtotalcount.Text = data.Split(':')[1].Trim();
            else if (data.StartsWith("Defective Count:")) // color defective
                defectivecolourcount.Text = data.Split(':')[1].Trim();
            /*else if (data.StartsWith("Dimension Defects:"))
                defectivedimensioncount.Text = data.Split(':')[1].Trim();*/
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            arduinoPort.WriteLine("STOP");
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            outputTextBox.Clear();
            arduinoPort.WriteLine("START");
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            /*
            string length = lengthtext.Text;
            string width = widthtext.Text;
            string height = heighttext.Text;
            outputTextBox.Clear();
            arduinoPort.WriteLine($"SET_DIMENSIONS,{length},{width},{height}");
            */
        }

        private void resetbuttonProduct_Click(object sender, EventArgs e)
        {
            // Send reset command to Arduino
            if (arduinoPort.IsOpen)
            {
                arduinoPort.WriteLine("RESET");
            }

            // Reset UI counters
            redcount.Clear();
            bluecount.Clear();
            greencount.Clear();
            goodtotalcount.Clear();
            defectivecolourcount.Clear();
            //defectivedimensioncount.Clear();
        }
    }
}
