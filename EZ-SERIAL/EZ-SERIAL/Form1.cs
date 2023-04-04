using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace CommunicateWithArduino
{
	public partial class Form1 : Form
	{
		public static System.IO.Ports.SerialPort port;
		delegate void SetTextCallback(string text);

		private bool terminateConnection = false;
		private bool connectionPaused = false;
		private bool threadIsRunning = false;

		private TextBox inTextBox;

		private Button sendButton;
		private Button clearButton;
		private Button refreshButton;
		private Button pauseButton;

		private CheckBox verboseCheckBox;
		

		// This BackgroundWorker is used to demonstrate the 
		// preferred way of performing asynchronous operations.
		private BackgroundWorker hardWorker;

		private Thread readThread = null;

		public Form1()
		{
			InitializeComponent();

			hardWorker = new BackgroundWorker();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			System.ComponentModel.IContainer components = 
				new System.ComponentModel.Container();
			port = new System.IO.Ports.SerialPort(components);
			if (comPort.SelectedItem == null)
			{
				MessageBox.Show("Please Select A Valid Port!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				port.PortName = comPort.SelectedItem.ToString();
				port.BaudRate = Int32.Parse(baudRate.SelectedItem.ToString());
				port.DtrEnable = true;
				port.ReadTimeout = 5000;
				port.WriteTimeout = 500;
				if (!port.IsOpen)
				{
					if(verboseCheckBox.Checked)
						this.SetText("Connecting to port...\r\n");
					try
					{
						if (inTextBox.Text != "")
						{
							DialogResult dialogResult = MessageBox.Show("Starting a new connection will clear the log window, Are you sure you want to continue? \n (You should probably save!)", "Unsaved Log!", MessageBoxButtons.YesNo);
							if (dialogResult == DialogResult.Yes)
							{
								this.ClearText();
								port.Open();
								if (verboseCheckBox.Checked)
									this.SetText("Connected to port: " + port.PortName.ToString() + "\n");

								clearButton.Enabled = true;
								sendButton.Enabled = true;

								readThread = new Thread(new ThreadStart(this.Read));
								readThread.Start();
								threadIsRunning = true;
								this.hardWorker.RunWorkerAsync();

								btnConnect.Text = "<Connected>";

								btnConnect.Enabled = false;
								terminateButton.Enabled = true;
								pauseButton.Enabled = true;
								comPort.Enabled = false;
							}
						}
					}
					catch (Exception error)
					{
						if (verboseCheckBox.Checked)
							this.SetText("Failed opening port!\r\n");
						MessageBox.Show("Couldn't Open Port " + "'" + port.PortName + "'! \n" + error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Port " + "'" + port.PortName + "' Is Already Open!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (string s in SerialPort.GetPortNames())
			{
				comPort.Items.Add(s);
			}
			//comPort.Items.Add("COM7"); //HC-06 INCOMING PORT
			//comPort.Items.Add("COM6"); //HC-06 OUTGOING PORT
			//comPort.SelectedIndex = 2;

			baudRate.Items.Add("2400");
			baudRate.Items.Add("4800");
			baudRate.Items.Add("9600");
			baudRate.Items.Add("14400");
			baudRate.Items.Add("19200");
			baudRate.Items.Add("28800");
			baudRate.Items.Add("38400");
			baudRate.Items.Add("57600");
			baudRate.Items.Add("115200");

			baudRate.SelectedIndex = 0;
			inTextBox = receiveText;

			sendButton = sendBtn;
			clearButton = clrBtn;
			refreshButton = refreshBtn;
			pauseButton = pauseBtn;
			terminateButton.Enabled = false;
			sendButton.Enabled = false;
			pauseButton.Enabled = false;

			refreshButton.Font = new Font("Wingdings 2", 10, FontStyle.Bold);
			refreshButton.Text = "⭮";
			refreshButton.Width = 25;
			refreshButton.Height = 25;

			verboseCheckBox = checkBox1;
		}

		private void sendBtn_Click(object sender, EventArgs e)
		{
			if (port.IsOpen)
			{
				port.Write(sendText.Text);

				if (verboseCheckBox.Checked)
				{
					this.receiveText.Text += "WRITE: " + DateTime.Now.ToString("G") + ": " + sendText.Text;
					this.receiveText.Text += "\r\n";
				}
			}
		}

		private void SetText(string text)
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			if (this.receiveText.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				this.Invoke(d, new object[] { text });
			}
			else
			{
				if (verboseCheckBox.Checked)
				{
					this.receiveText.Text += "READ: " + DateTime.Now.ToString("G") + ": "; 
				}
				this.receiveText.Text += text;
				this.receiveText.Text += "\r\n";
			}
		}
		private void ClearText()
		{
			inTextBox.Clear();
		}

		public void Read()
		{
			while (port.IsOpen)
			{
				try
				{
					string message = port.ReadLine();
					this.SetText(message);
				}
				catch (Exception) {
					//this.SetText("<Terminated Connection>");
				}
			}
		}

        [Obsolete]
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (readThread != null && threadIsRunning)
				readThread.Suspend();

			if(port != null)
				port.Close();

			readThread.Abort();
		}

		private void clrBtn_Click(object sender, EventArgs e)
		{
			if (port.IsOpen)
			{
				byte[] stuff = { 0x7C, 0x00 };
				port.Write(stuff, 0, 2);
				this.ClearText();
			}
		}
        private void terminateButton_Click(object sender, EventArgs e)
        {
			threadIsRunning = false;
			if(verboseCheckBox.Checked)
				this.SetText("<Connection Terminated>");
			terminateConnection = true;
			port.Close();
			btnConnect.Text = "Connect";

			btnConnect.Enabled = true;
			terminateButton.Enabled = false;
			comPort.Enabled = true;
			sendBtn.Enabled = false;
		}

        private void textFiletxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
			SaveFileDialog file_diag = new SaveFileDialog();
			file_diag.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			try
            {
				if (file_diag.ShowDialog() == DialogResult.OK)
				{
					using (StreamWriter writer = new StreamWriter(file_diag.OpenFile()))
					{
						writer.WriteLine(receiveText.Text);

						writer.Dispose();

						writer.Close();
					}
				}
			}
            catch (Exception error)
            {
				MessageBox.Show("Couldn't Save File: " + error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
        private void refreshBtn_Click(object sender, EventArgs e)
        {
			foreach (string s in SerialPort.GetPortNames())
			{
				comPort.Items.Clear();
				comPort.Items.Add(s);
			}
		}

        [Obsolete]
        private void pauseBtn_Click(object sender, EventArgs e)
        {
			if (connectionPaused == false)
			{
				threadIsRunning = false;
				terminateButton.Enabled = false;
				connectionPaused = true;
				readThread.Suspend();
				pauseButton.Text = "Resume Connection";
				if(verboseCheckBox.Checked)
					this.SetText("<Connection Paused>");
			}
			else
			{
				terminateButton.Enabled = true;
				readThread.Resume();
				connectionPaused = !connectionPaused;
				pauseButton.Text = "Pause Connection";
				this.SetText("<Connection Resumed>");
			}
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
			System.Diagnostics.Process.Start("http://www.website.com");//Redirect to github page
		}
    }
}
