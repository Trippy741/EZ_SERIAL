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
namespace CommunicateWithArduino
{
    internal class SerialPort_outputBox : ControlNode
    {
        public Output<string> serial_string;
        public static SerialPort port;

        private ComboBox baudRateBox;
        private ComboBox comPort;

        private Label comPort_label;
        private Label baudRateLabel;

        private RadioButton inputRadioButton;
        private RadioButton outputRadioButton;

        private bool startTracking = false;

        public SerialPort_outputBox(Control Context, int node_id, string node_label_string) : base(Context, node_id, node_label_string)
        {
            inputRadioButton = new RadioButton();
            outputRadioButton = new RadioButton();

            baudRateBox = new ComboBox();
            comPort = new ComboBox();

            baudRateLabel = new Label();
            comPort_label = new Label();

            baudRateBox.Width = 120;
            baudRateBox.Height = 25;

            comPort.Width = 120;
            comPort.Height = 25;

            baudRateLabel.Text = "Baud Rate: ";
            comPort_label.Text = "COM Port: ";

            comPort_label.Location = new Point(8, 30);
            baudRateLabel.Location = new Point(8, 60);

            baudRateBox.Location = new Point(80, 60);
            comPort.Location = new Point(80, 30);

            inputRadioButton.Location = new Point(0,80);
            outputRadioButton.Location = new Point(190,80);

            baudRateBox.Items.Add("2400");
            baudRateBox.Items.Add("4800");
            baudRateBox.Items.Add("9600");
            baudRateBox.Items.Add("14400");
            baudRateBox.Items.Add("19200");
            baudRateBox.Items.Add("28800");
            baudRateBox.Items.Add("38400");
            baudRateBox.Items.Add("57600");
            baudRateBox.Items.Add("115200");

            baudRateBox.SelectedIndex = 0;



            foreach (string s in SerialPort.GetPortNames())
            {
                comPort.Items.Add(s);
            }

            inputRadioButton.MouseDown += InputRadioOnMouseDownHandler;
            inputRadioButton.MouseUp += InputRadioOnMouseUpHandler;
            Context.MouseMove += MouseMoveHandler;


            //Adding the controls
            AddNodeControls(baudRateBox);
            AddNodeControls(comPort);
            AddNodeControls(inputRadioButton);
            AddNodeControls(outputRadioButton);

            //Adding the labels
            AddNodeLabels(comPort_label);
            AddNodeLabels(baudRateLabel);
            //Add in code later on to actually create the components (or create it, build it, and import it as a DLL into the toolbox folder)
        }
        private void MouseMoveHandler(object sender, EventArgs e)
        {
            //Multithread this shit
            if (startTracking == false)
            {
                DrawBezier(inputRadioButton.Location,Cursor.Position);
            }
        }
        private void InputRadioOnMouseDownHandler(object sender, EventArgs e)
        {
            startTracking = true;
        }
        private void InputRadioOnMouseUpHandler(object sender, EventArgs e)
        {
            startTracking = false;
        }
    }
}
