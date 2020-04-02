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
                connectToMCU();
            }
            else
            {
                disconnectFromMCU();
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToMCU()
        {
            try
            {
                isConnected = true;
                connectB.Text = "Disconnect";
                enableControls();
                string selectedPort = serialportCB.GetItemText(serialportCB.SelectedItem);
                port = new SerialPort(selectedPort, 115200, Parity.None, 8, StopBits.One);
                port.Open();
                port.Write("#STAR\n");
            }
            catch (Exception)
            {
                isConnected = false;
                connectB.Text = "Connect";
                disableControls();
                MessageBox.Show("Select a valid COM port");
            }
        }

        private void disconnectFromMCU()
        {
            try
            {
                port.Write("#STOP\n");
                port.Close();
                isConnected = false;
                connectB.Text = "Connect";
                serialportCB.SelectedIndex = -1;
                disableControls();
            }
            catch (Exception)
            {
                MessageBox.Show("Disconnection Error Encountered");
            }
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
