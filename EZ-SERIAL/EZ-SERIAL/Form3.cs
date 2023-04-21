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
            editMode = !editMode;
            foreach (CustomButton button in buttons)
            {
                button.ToggleDraggable();
            }
        }
        private void OnCustomButtonMouseClick(object sender, MouseEventArgs e)
        {
            propertiesGroupBoxes.Clear();
            foreach (Control control in panel1.Controls)
                panel1.Controls.Remove(control);

            CustomButton senderBtn = (CustomButton)sender;

            foreach (KeyValuePair<string,List<CustomProperty>> entry in senderBtn.customPropertyDictionary)
            {
                CustomPropertiesGroupBox groupBox = new CustomPropertiesGroupBox(senderBtn.propertyChangeCallback,entry.Key, entry.Value);
                panel1.Controls.Add(groupBox);
            }
        }

        private void newButtonBtn_Click(object sender, EventArgs e)
        {
            CustomButton btn = new CustomButton();
            dashboardGroupBox.Controls.Add(btn);
            buttons.Add(btn);
            btn.MouseDown += OnCustomButtonMouseClick;
        }
    }
}
