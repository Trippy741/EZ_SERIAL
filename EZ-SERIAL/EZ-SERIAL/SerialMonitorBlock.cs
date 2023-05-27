using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    public partial class SerialMonitorBlock : UserControl
    {
        SerialPort serialPort;

        public SerialMonitorBlock()
        {
            InitializeComponent();
        }

        private void SerialMonitorBlock_Load(object sender, EventArgs e)
        {
            serialPort = new SerialPort(components);
            serialPort.PortName = selectedPortComboBox.SelectedItem.ToString();
            serialPort.BaudRate = Int32.Parse(baudRateComboBox.SelectedItem.ToString());
            serialPort.DtrEnable = true;
            serialPort.ReadTimeout = 5000;
            serialPort.WriteTimeout = 500;
        }
    }
}
