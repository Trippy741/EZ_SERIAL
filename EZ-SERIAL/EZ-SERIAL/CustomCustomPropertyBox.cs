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
    public partial class CustomCustomPropertyBox : UserControl
    {
        public string property_title;
        public Control customControl;
        public CustomCustomPropertyBox(string property_title, Control customControl)
        {
            InitializeComponent();
            this.property_title = property_title;
            this.customControl = customControl;
        }

        private void CustomCustomPropertyBox_Load(object sender, EventArgs e)
        {
            
        }
    }
}
