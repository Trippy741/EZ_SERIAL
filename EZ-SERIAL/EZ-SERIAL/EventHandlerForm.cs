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
    public partial class EventHandlerForm : Form
    {
        public List<Control> CustomControls { get; set; }
        public EventHandlerForm()
        {
            InitializeComponent();
        }

        private void EventHandlerForm_Load(object sender, EventArgs e)
        {
            foreach (Control control in CustomControls)
            {
                ICustomControl customControl = control as ICustomControl;
                customControlComboBox.Items.Add(customControl.ControlTitle());
            }
            customControlComboBox.SelectionChangeCommitted += OnCustomControlComboBoxChanged;
        }
        private void OnCustomControlComboBoxChanged(object sender,EventArgs eventArgs)
        {
            ComboBox comboBox = sender as ComboBox;
            foreach (Control control in CustomControls)
            {
                ICustomControl customControl = control as ICustomControl;
                if (customControl.ControlTitle() == comboBox.SelectedItem.ToString())
                {
                    MessageBox.Show("it's workang");
                    foreach (KeyValuePair<string, List<CustomEvent>> entry in customControl.ReturnCustomEventPropertyDictionary())
                    {
                        CustomPropertiesGroupBox groupBox = new CustomPropertiesGroupBox(customControl, entry.Key, entry.Value);
                        panel1.Controls.Add(groupBox);
                        MessageBox.Show("it's workang");
                    }
                }
                
            }
        }
    }
}
