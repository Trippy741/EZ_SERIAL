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
        public List<Control> customControls = new List<Control>();
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
            foreach (CustomButtonControl button in customControls)
            {
                button.ToggleDraggable();
            }
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

            /*if (sender.GetType() == typeof(CustomButtonControl))
            {
                CustomButtonControl button = (CustomButtonControl)sender;
                foreach (KeyValuePair<string, List<CustomProperty>> entry in button.customPropertyDictionary)
                {
                    CustomPropertiesGroupBox groupBox = new CustomPropertiesGroupBox(button, entry.Key, entry.Value);
                    panel1.Controls.Add(groupBox);
                }
            }
            if (sender.GetType() == typeof(CustomTimerControl))
            {
                CustomTimerControl timer = (CustomTimerControl)sender;
                foreach (KeyValuePair<string, List<CustomProperty>> entry in timer.customPropertyDictionary)
                {
                    CustomPropertiesGroupBox groupBox = new CustomPropertiesGroupBox(timer, entry.Key, entry.Value);
                    panel1.Controls.Add(groupBox);
                }
            }*/
            if (typeof(ICustomControl).IsAssignableFrom(typeof(CustomButtonControl)))
            {
                ICustomControl CustomControlTemp = (ICustomControl)sender;
                foreach (KeyValuePair<string, List<CustomProperty>> entry in CustomControlTemp.ReturnCustomControlPropertyDictionary())
                {
                    CustomPropertiesGroupBox groupBox = new CustomPropertiesGroupBox(CustomControlTemp, entry.Key, entry.Value);
                    panel1.Controls.Add(groupBox);
                }
            }
        }

        private void newButtonBtn_Click(object sender, EventArgs e)
        {
            CustomButtonControl btn = new CustomButtonControl();
            dashboardGroupBox.Controls.Add(btn);
            customControls.Add(btn);
            btn.MouseDown += OnCustomControlMouseClick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomTimerControl timer = new CustomTimerControl();
            dashboardGroupBox.Controls.Add(timer);
            customControls.Add(timer);
            //timer.MouseDown += delegate (object _sender, MouseEventArgs _e) { OnCustomControlMouseClick(sender, _e, "CUSTOM_TIMER"); };
        }

        private void eventHandler_btn_Click(object sender, EventArgs e)
        {
            EventHandlerForm eventHandlerForm = new EventHandlerForm();
            eventHandlerForm.CustomControls = this.customControls;
            eventHandlerForm.Show();
        }
    }
}
