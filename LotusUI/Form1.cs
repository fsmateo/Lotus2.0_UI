﻿using System;
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

namespace LotusUI
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        bool manualControlDirection = false;
        String[] ports;
        SerialPort port;
        string cmd, inData;
        string[] rxData = new string[5];
        // variation w/o use of MCU
        List<string> loraSetting = new List<string>();
        //

        DBConnect DB1;
        const char DELIMITER = '$';
        String inputString;
        String[] dataEntries = new String[7];
        String date, time, longitude, latitude, temperature, humidity, _object, times_found, score;
        DateTime Time;
        FileStream outFile;
        StreamWriter writer;

        public Form1()
        {
            InitializeComponent();
            disableControls();
            connectToDatabase();
            outFile = new FileStream("data.txt", FileMode.Append, FileAccess.Write);
            writer = new StreamWriter(outFile);

            // variation w/o use of MCU
            loraSetting.Add("AT+IPR=115200\r\n");
            loraSetting.Add("AT+ADDRESS=100\r\n");
            loraSetting.Add("AT+NETWORKID=5\r\n");
            loraSetting.Add("AT+MODE=0\r\n");
            loraSetting.Add("AT+BAND=908700000\r\n");
            loraSetting.Add("AT+PARAMETER=10,7,1,7\r\n");
            //

            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                serialportCB.Items.Add(port);
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

        private void connectToMCU()
        {
            try
            {
                isConnected = true;
                connectB.Text = "Disconnect";
                enableControls();
                string selectedPort = serialportCB.GetItemText(serialportCB.SelectedItem);
                port = new SerialPort(selectedPort, 115200, Parity.None, 8, StopBits.One);
                port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                port.Open();
                // variation w/o use of MCU
                foreach (string setting in loraSetting)
                {
                    port.Write(setting);
                    System.Threading.Thread.Sleep(100);
                }
                //
                //port.Write("#STAR\n");
                port.Write("AT+SEND=200,4,STAR\r\n");
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
                //port.Write("#STOP\n");
                port.Write("AT+SEND=200,4,STOP\r\n");
                port.Close();
                isConnected = false;
                connectB.Text = "Connect";
                serialportCB.SelectedIndex = -1;
                manualControlButton.Text = "Enable Manual Control";
                this.KeyPreview = false;
                disableControls();
            }
            catch (Exception) { }
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

        private void manualControlButton_Click(object sender, EventArgs e)
        {
            if(manualControlButton.Text.Contains("Enable"))
            {
                manualControlButton.Text = "Disable Manual Control";
                this.KeyPreview = true;
                manualControlDirection = true;
            }
            else
            {
                manualControlButton.Text = "Enable Manual Control";
                this.KeyPreview = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (manualControlDirection)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.W:
                            forwardButton.BackColor = SystemColors.ActiveCaption;
                            //port.Write("#FORW\n");
                            port.Write("AT+SEND=200,4,FORW\r\n");
                            break;
                        case Keys.S:
                            reverseButton.BackColor = SystemColors.ActiveCaption;
                            //port.Write("#REVE\n");
                            port.Write("AT+SEND=200,4,REVE\r\n");
                            break;
                        case Keys.A:
                            leftButton.BackColor = SystemColors.ActiveCaption;
                            //port.Write("#LEFT\n");
                            port.Write("AT+SEND=200,4,LEFT\r\n");
                            break;
                        case Keys.D:
                            rightButton.BackColor = SystemColors.ActiveCaption;
                            //port.Write("#RIGH\n");
                            port.Write("AT+SEND=200,4,RIGH\r\n");
                            break;
                        default:
                            break;
                    }
                    manualControlDirection = false;
                }
            }
            catch (Exception) { }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                forwardButton.BackColor = SystemColors.Control;
                reverseButton.BackColor = SystemColors.Control;
                leftButton.BackColor = SystemColors.Control;
                rightButton.BackColor = SystemColors.Control;
                //port.Write("#BRAK\n");
                port.Write("AT+SEND=200,4,BRAK\r\n");
                manualControlDirection = true;
            }
            catch (Exception) { }
        }

        private void connectToDatabase()
        {
            try
            {
                DB1 = new DBConnect();
                databaseLabel.Visible = true;
                databaseLabel.Text = "Connected to Database";
            }
            catch (Exception)
            {
                databaseLabel.Visible = true;
                databaseLabel.Text = "ERROR: Can't Connect to DB";
            }
        }

        private void connectDBB_Click(object sender, EventArgs e)
        {
            connectToDatabase();
        }

        private void simulateB_Click(object sender, EventArgs e)
        {
            try
            {
                //inputString = "-117.086418$33.119205$74$44$bird$4$99.71";   //CHANGE TO: Input from LoRA
                cmd = "AT+SEND=200,4,DATA\r\n";
                port.Write(cmd);
                richTextBox1.AppendText(cmd);
                //storeData(inputString);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message + ex.StackTrace);
            }

        }

        private void storeData(string inputString)
        {
            try
            {
                Time = DateTime.Now;
                date = Time.Date.ToString("yyyy-MM-dd");
                time = Time.Hour + ":" + Time.Minute + ":" + Time.Second;

                dataEntries = inputString.Split(DELIMITER);
                longitude = dataEntries[0];
                latitude = dataEntries[1];
                temperature = dataEntries[2];
                humidity = dataEntries[3];
                _object = dataEntries[4];
                times_found = dataEntries[5];
                score = dataEntries[6];

                DB1.Insert(date, time, longitude, latitude, temperature, humidity, _object, times_found, score);
                databaseLabel.Text = "Data Stored Successfully";
            }
            catch(Exception)
            {
                writer.WriteLine(date + "$" + time + "$" + inputString);
                databaseLabel.Text = "ERROR: Couldn't Store Data\nStored in Local File Instead";
            }
        }

        private void sendB_Click(object sender, EventArgs e)
        {

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            inData = port.ReadExisting();
            this.Invoke(new EventHandler(ParseReceivedData));
        }

        private void ParseReceivedData(object sender, EventArgs e)
        {
            if (inData.Contains("+OK"))
            {
                richTextBox1.AppendText(inData);
            }
            if (inData.Contains("+RCV"))
            {
                rxData = inData.Split(',');
                inputString = rxData[2];
                richTextBox1.AppendText(inputString + "\n");
                storeData(inputString);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            writer.Close();
            outFile.Close();
            disconnectFromMCU();
            Application.Exit();
        }
    }
}
