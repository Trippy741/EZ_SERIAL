using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal class ControlNode_Value_String : ControlNode
    {
        private RadioButton outputRadioButton;
        private TextBox valueTextBox;
        private Label value_label;

        public string outputValue { get; set; }

        public ControlNode_Value_String(Control Context, int node_id, string node_label_string) : base(Context , node_id, node_label_string)
        {
            outputRadioButton = new RadioButton();
            valueTextBox = new TextBox();
            value_label = new Label();

            node_panel.Size = new Size(212, 55);

            valueTextBox.Size = new Size(100, 22);

            value_label.Location = new Point(3, 18);
            outputRadioButton.Location = new Point(192, 21);
            valueTextBox.Location = new Point(86, 17);

            value_label.Text = "String Value: ";

            AddNodeControls(outputRadioButton);
            AddNodeControls(valueTextBox);
            AddNodeControls(value_label);

            outputRadioButton.BringToFront();
            valueTextBox.BringToFront();
            value_label.BringToFront();
        }
    }
}
