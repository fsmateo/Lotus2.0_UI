// Testing Pull Request V3...
// Testing Pull Request V4...
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

namespace LotusUI
{
    public partial class Form1 : Form
    {
        //Joncy was here
        bool isConnected = false;
        String[] ports;
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
            disableControls();
            ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                serialportCB.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    serialportCB.SelectedItem = ports[0];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                forwardB.PerformClick();
            }
            if (e.KeyCode == Keys.Down)
            {
                reverseB.PerformClick();
            }
            if (e.KeyCode == Keys.Left)
            {
                leftB.PerformClick();
            }
            if (e.KeyCode == Keys.Right)
            {
                rightB.PerformClick();
            }
        }

        private void connectB_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        private void connectToArduino()
        {
            try
            {
                isConnected = true;
                string selectedPort = serialportCB.GetItemText(serialportCB.SelectedItem);
                port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                port.Open();
                port.Write("#STAR\n");
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error Encountered");
            }
            connectB.Text = "Disconnect";
            enableControls();
        }

        private void disconnectFromArduino()
        {
            try
            {
                isConnected = false;
                port.Write("#STOP\n");
                port.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Disconnection Error Encountered");
            }
            connectB.Text = "Connect";
            disableControls();
            resetDefaults();
        }

        private void enableControls()
        {
            destGB.Enabled = true;
            manualConGB.Enabled = true;
        }

        private void disableControls()
        {
            destGB.Enabled = false;
            manualConGB.Enabled = false;
        }

        private void resetDefaults()
        {
            
        }

        private void forwardB_KeyDown(object sender, KeyEventArgs e)
        {
            if (isConnected)
            {
                port.Write("#FORWARD\n");
            }
        }

        private void reverseB_KeyDown(object sender, KeyEventArgs e)
        {
            if (isConnected)
            {
                port.Write("#REVERSE\n");
            }
        }

        private void leftB_KeyDown(object sender, KeyEventArgs e)
        {
            if (isConnected)
            {
                port.Write("#LEFT\n");
            }
        }

        private void rightB_KeyDown(object sender, KeyEventArgs e)
        {
            if (isConnected)
            {
                port.Write("#RIGHT\n");
            }
        }

        private void sendB_Click(object sender, EventArgs e)
        {

        }
    }
}
