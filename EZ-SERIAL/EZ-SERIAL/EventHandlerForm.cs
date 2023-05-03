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
            for (int i = 0; i > customControlComboBox.Items.Count; i++)
            {
                
            }
        }
        private void OnCustomControlComboBoxChanged(object sender,EventArgs eventArgs)
        {
            ComboBox comboBox = sender as ComboBox;
            MessageBox.Show("Triggered Event!");
            foreach (Control control in CustomControls)
            {
                ICustomControl customControl = control as ICustomControl;
                if (customControl.ControlTitle() == comboBox.SelectedText)
                {
                    CustomPropertiesGroupBox groupBox = new CustomPropertiesGroupBox(customControl,"Events",customControl.);
                }
                
            }
        }
    }
}
