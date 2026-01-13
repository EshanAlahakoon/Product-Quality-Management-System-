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
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort arduinoPort;
        public Form1()
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
                outputTextBox.Clear();
                //checkRecevingData(data);
                outputTextBox.AppendText(data);
            }));*/
        }

        /*
        void checkRecevingData(string data)
        {
            if(data == "Red Color" || data == "Blue Color" || data == "Green Color" || data == "Defective Product")
            {
                outputTextBox.AppendText(data);
            }
        }
        */

        // Update text boxes based on Arduino data
        private void UpdateData(string data)
        {
            if (data.StartsWith("Red Count:"))
                redcount.Text = data.Split(':')[1].Trim();
            else if (data.StartsWith("Green Count:"))
                greencount.Text = data.Split(':')[1].Trim();
            else if (data.StartsWith("Blue Count:"))
                bluecount.Text = data.Split(':')[1].Trim();
            else if (data.StartsWith("Total Count:"))
                totalcount.Text = data.Split(':')[1].Trim();
            else if (data.StartsWith("Defective Count:"))
                defectivecount.Text = data.Split(':')[1].Trim();
            /*
            else if (data.StartsWith("Dimension Defects:"))
                defectivedimensioncount.Text = data.Split(':')[1].Trim(); */
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
            totalcount.Clear();
            defectivecount.Clear();


        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
