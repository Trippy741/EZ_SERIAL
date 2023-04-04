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
    public partial class Form2 : Form
    {
        private List<ControlNode> controlNodes = new List<ControlNode>();
        private Control Context;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Context = groupBox1;
            //testNode = new SerialPort_outputBox(this,0,"COM PORT A");
            //testNode = new SerialPort_outputBox(this,0,"COM PORT B");

        }

        private void controlNodeButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new NodeCreationDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    switch (dialog.node_type)
                    {
                        case ControlNode.nodeType.COM_PORT:
                            {
                                controlNodes.Add(new SerialPort_outputBox(this.Context, dialog.node_id_int, dialog.node_label_string));
                                break;
                            }
                        case ControlNode.nodeType.VALUE:
                            {
                                controlNodes.Add(new ControlNode_Value_String(this.Context, dialog.node_id_int, dialog.node_label_string));
                                break;
                            }
                        case ControlNode.nodeType.EMPTY:
                            {
                                controlNodes.Add(new ControlNode(this.Context,dialog.node_id_int,dialog.node_label_string));
                                break;
                            }
                    }
                }
                else
                {
                    //Used for debugging dialog results and such
                    //MessageBox.Show("Failed Creating Node: " + result.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
