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
    public partial class CustomPropertiesBox_userControl : UserControl
    {
        public string title;
        public string description;
        public CustomProperty customProperty;

        public TextBox textBox;
        public CheckBox checkBox;
        public Panel panel;
        public ComboBox comboBox;
        public CustomPropertiesBox_userControl(string title, CustomProperty customProperty)
        {
            InitializeComponent();
            this.title = title;
            this.customProperty = customProperty;

            textBox = textBox1;
            checkBox = checkBox1;
            panel = panel11;
            comboBox = comboBox1;
        }

        private void CustomCustomPropertiesBox_Load(object sender, EventArgs e)
        {
            label3.Text = title;

            comboBox1.Visible = false;
            checkBox1.Visible = false;
            panel11.Visible = false;
            textBox1.Visible = false;

            if (customProperty.propertyControl is ComboBox)
            {
                comboBox1.Parent = null;
                panel10.Controls.Add(comboBox1);
                comboBox1.Visible = true;
            }
            if (customProperty.propertyControl is CheckBox)
            {
                checkBox1.Parent = null;
                panel10.Controls.Add(checkBox1);
                checkBox1.Visible = true;
            }
            if (customProperty.propertyControl is Panel)
            {
                panel11.Parent = null;
                panel10.Controls.Add(panel11);
                panel11.Visible = true;
            }
            if (customProperty.propertyControl is TextBox)
            {
                textBox1.Parent = null;
                panel10.Controls.Add(textBox1);
                textBox1.Visible = true;
            }
        }
    }
}
