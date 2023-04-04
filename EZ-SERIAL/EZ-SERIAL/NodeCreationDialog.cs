using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    public partial class NodeCreationDialog : Form
    {
        public string node_label_string { get; set; }
        public int node_id_int { get; set; }

        public ControlNode.nodeType node_type;

        private TextBox nodeLabel_textBox;
        private TextBox nodeID_textBox;

        private Button ok_button;
        private Button cancel_button;

        private ComboBox nodeType_comboBox;

        public NodeCreationDialog()
        {
            InitializeComponent();
        }

        private void NodeCreationDialog_Load(object sender, EventArgs e)
        {
            nodeLabel_textBox = nodeTitleTextBox;
            nodeID_textBox = nodeIDTextBox;
            nodeType_comboBox = nodeTypeComboBox;

            ok_button = okButton;
            cancel_button = cancelButton;

            nodeTypeComboBox.DataSource = Enum.GetValues(typeof(ControlNode.nodeType));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            node_type = (ControlNode.nodeType)nodeTypeComboBox.SelectedValue;
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
