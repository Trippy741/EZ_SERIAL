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
    public partial class CustomBorderlessButton : UserControl
    {
        string buttonTitle;
        public CustomBorderlessButton(string buttonTitle)
        {
            InitializeComponent();
            this.buttonTitle = buttonTitle;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
