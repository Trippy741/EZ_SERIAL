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
        private List<CustomControl> customControls = new List<CustomControl>();
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
        }
        /*private void OnCustomButtonMouseClick(object sender, MouseEventArgs e)
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
        }*/
        private void OnCustomControlMouseClick(object sender, MouseEventArgs e)
        {
            propertiesGroupBoxes.Clear();
            foreach (Control control in panel1.Controls)
                panel1.Controls.Remove(control);

            //Control tempControl = new Control();
            MessageBox.Show(sender.GetType().ToString());
            /*if ()
            {
                CustomButtonControl button = (CustomButtonControl)sender;
                foreach (KeyValuePair<string, List<CustomProperty>> entry in button.customPropertyDictionary)
                {
                    CustomPropertiesGroupBox groupBox = new CustomPropertiesGroupBox(button.propertyChangeCallback, entry.Key, entry.Value);
                    panel1.Controls.Add(groupBox);
                }
            }*/
            /*if (control_type == "CUSTOM_TIMER")
            {
                foreach (KeyValuePair<string, List<CustomProperty>> entry in tempControl.customPropertyDictionary)
                {
                    CustomPropertiesGroupBox groupBox = new CustomPropertiesGroupBox(tempControl.propertyChangeCallback, entry.Key, entry.Value);
                    panel1.Controls.Add(groupBox);
                }
            }*/
        }

        private void newButtonBtn_Click(object sender, EventArgs e)
        {
            CustomButtonControl btn = new CustomButtonControl();
            dashboardGroupBox.Controls.Add(btn);
            btn.MouseDown += OnCustomControlMouseClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomTimerControl timer = new CustomTimerControl();
            dashboardGroupBox.Controls.Add(timer);
            customControls.Add(timer);
            //timer.MouseDown += delegate (object _sender, MouseEventArgs _e) { OnCustomControlMouseClick(sender, _e, "CUSTOM_TIMER"); };
        }
    }
}
