using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal class if_Node : ControlNode
    {
        private Panel box;
        private Label label;
        private ComboBox comboBox;

        private string boxText;

        public if_Node(Form Context,string boxText, int node_id, string node_label_string) : base(Context, node_id, node_label_string)
        {
            this.boxText = boxText;
        }
    }
}
