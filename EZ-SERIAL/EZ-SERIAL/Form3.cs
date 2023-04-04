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
    public partial class Form3 : Form
    {
        private bool editMode = true;
        private List<Button> buttons = new List<Button>();
        private List<CustomPropertiesGroupBox> propertiesGroupBoxes = new List<CustomPropertiesGroupBox>();
          
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void editModeBtn_Click(object sender, EventArgs e)
        {
            propertiesGroupBoxes.Add(new CustomPropertiesGroupBox("Appearance"));
            propertiesGroupBoxes[0].AddCustomPropertyPanel();
            propertiesGroupBoxes[0].AddCustomPropertyPanel();
            panel1.Controls.Add(propertiesGroupBoxes[0]);
        }
        private void setPropertiesPanel(object sender, MouseEventArgs e)
        {
            
        }

        private void newButtonBtn_Click(object sender, EventArgs e)
        {
            CustomButton btn = new CustomButton();
            dashboardGroupBox.Controls.Add(btn);
            buttons.Add(btn);
            btn.MouseDown += setPropertiesPanel;
        }
    }
}
