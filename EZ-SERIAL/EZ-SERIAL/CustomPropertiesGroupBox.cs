using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace CommunicateWithArduino
{
    internal class CustomPropertiesGroupBox : GroupBox
    {
        private int locationYMargin = 50;
        public List<CustomPropertiesPanel> propertyPanels = new List<CustomPropertiesPanel>();

        private CustomButtonControl.propertyChangeApply callbackDelegate;
        private List<CustomProperty> customPropertyList = new List<CustomProperty>();

        /*public CustomPropertiesGroupBox(Control.propertyChangeApply callbackDelegate, string groupBoxTitle, List<CustomProperty> customPropertyList)
        {
            this.customPropertyList.Clear();
            propertyPanels.Clear();

            this.callbackDelegate = callbackDelegate;
            this.customPropertyList.AddRange(customPropertyList);

            for (int i = 0; i < this.customPropertyList.Count; i++)
            {
                propertyPanels.Add(new CustomPropertiesPanel(this.customPropertyList[i]));
            }
            this.AutoSize = true;
            this.Dock = DockStyle.Top;
            this.Text = groupBoxTitle;
            spaceApartPropertyPanels();
            SetCustomOnChangeEvent();
        }*/
        public CustomPropertiesGroupBox(string groupBoxTitle, List<CustomProperty> customPropertyList)
        {
            this.customPropertyList.Clear();
            propertyPanels.Clear();

            this.callbackDelegate = callbackDelegate;
            this.customPropertyList.AddRange(customPropertyList);

            for (int i = 0; i < this.customPropertyList.Count; i++)
            {
                propertyPanels.Add(new CustomPropertiesPanel(this.customPropertyList[i]));
            }
            this.AutoSize = true;
            this.Dock = DockStyle.Top;
            this.Text = groupBoxTitle;
            spaceApartPropertyPanels();
            SetCustomOnChangeEvent();
        }
        public void SetCustomOnChangeEvent()
        {

            foreach (CustomPropertiesPanel panel in propertyPanels)
            {
                if (panel.propertyControl.GetType() == typeof(TextBox))
                {
                    TextBox panelTextBox = (TextBox)panel.propertyControl;
                    panelTextBox.TextChanged += delegate (object sender, EventArgs e) { customTextBoxControl_TextChanged(sender, e, panel); };
                }
                if (panel.propertyControl.GetType() == typeof(CheckBox))
                {
                    CheckBox panelCheckBox = (CheckBox)panel.propertyControl;
                    panelCheckBox.CheckedChanged += delegate (object sender, EventArgs e) { customCheckBoxControl_CheckChanged(sender, e, panel); };
                }
                if (panel.propertyControl.GetType() == typeof(Panel) && panel.customProperty.propertyName == "BG Color")
                {
                    Panel panelControl = (Panel)panel.propertyControl;
                    panelControl.Click += delegate (object sender, EventArgs e) { customBGColorDialogControl_ColorChanged(sender, e, panel); };
                }
                if (panel.propertyControl.GetType() == typeof(Panel) && panel.customProperty.propertyName == "FG Color")
                {
                    Panel panelControl = (Panel)panel.propertyControl;
                    panelControl.Click += delegate (object sender, EventArgs e) { customFGColorDialogControl_ColorChanged(sender, e, panel); };
                }
                if (panel.propertyControl.GetType() == typeof(TextBox) && panel.customProperty.propertyName == "Size(X, Y)")
                {
                    TextBox panelControl = (TextBox)panel.propertyControl;
                    //Change this event to activate only when the user presses the ENTER or SPACE keys
                    panelControl.Click += delegate (object sender, EventArgs e) { customSizeTextBoxControl_TextChanged(sender, e, panel); };
                }
            }
        }
        private void customTextBoxControl_TextChanged(object sender, EventArgs e, CustomPropertiesPanel panel)
        {
            TextBox senderTextBox = (TextBox)sender;

            foreach (CustomProperty customProperty in customPropertyList)
            {
                if (customProperty == panel.customProperty)
                {
                    customProperty.propertyControl.Text = panel.customProperty.propertyControl.Text;
                }
            }
            callbackDelegate(this.Text, customPropertyList);
            //Change the custom properties within the list
            //So that the callback function could bring those values back to the custom button
        }
        private void customCheckBoxControl_CheckChanged(object sender, EventArgs e, CustomPropertiesPanel panel)
        {
            CheckBox senderCheckBox = (CheckBox)sender;
            foreach (CustomProperty customProperty in customPropertyList)
            {
                if (customProperty == panel.customProperty)
                {
                    customProperty.propertyControl = senderCheckBox;
                }
            }
            callbackDelegate(this.Text, customPropertyList);
        }
        private void customBGColorDialogControl_ColorChanged(object sender, EventArgs e, CustomPropertiesPanel panel)
        {
            Panel panelSender = (Panel)sender;
            foreach (CustomProperty customProperty in customPropertyList)
            {
                if (customProperty == panel.customProperty)
                {
                    MessageBox.Show("BG");
                    ColorDialog colorDialog = new ColorDialog();
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                        customProperty.propertyControl.BackColor = colorDialog.Color;
                }
            }
            callbackDelegate(this.Text, customPropertyList);
        }
        private void customFGColorDialogControl_ColorChanged(object sender, EventArgs e, CustomPropertiesPanel panel)
        {
            Panel panelSender = (Panel)sender;
            foreach (CustomProperty customProperty in customPropertyList)
            {
                if (customProperty == panel.customProperty)
                {
                    MessageBox.Show("FG");
                    ColorDialog colorDialog = new ColorDialog();
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                        customProperty.propertyControl.ForeColor = colorDialog.Color;
                }
            }
            callbackDelegate(this.Text, customPropertyList);
        }
        private void customSizeTextBoxControl_TextChanged(object sender, EventArgs e, CustomPropertiesPanel panel)
        {
            TextBox senderTextBox = (TextBox)sender;

            foreach (CustomProperty customProperty in customPropertyList)
            {
                if (customProperty == panel.customProperty)
                {
                    if(senderTextBox.Text.Count(t => t == ',') != 1)
                        MessageBox.Show("Invalid Input!");
                    foreach (char c in senderTextBox.Text)
                        if (!Char.IsDigit(c))
                            MessageBox.Show("Invalid Input!");

                    string[] split_size = senderTextBox.Text.Split(',');
                    if (split_size.Length != 2)
                        MessageBox.Show("Invalid Input!");
                    else
                    {
                        customProperty.propertyControl.Text = senderTextBox.Text;
                    }
                }
            }
            callbackDelegate(this.Text, customPropertyList);
        }
        public void spaceApartPropertyPanels()
        {
            foreach (Control control in this.Controls)
                this.Controls.Remove(control);

            if (propertyPanels.Count > 0)
            {
                List<CustomPropertiesPanel> panels = new List<CustomPropertiesPanel>();
                panels.AddRange(propertyPanels);
                foreach (CustomPropertiesPanel panel in panels)
                {
                    propertyPanels.Remove(panel);
                    System.Drawing.Point location;

                    if (propertyPanels.Count > 0)
                        location = new System.Drawing.Point(propertyPanels.Last().Location.X, propertyPanels.Last().Location.Y + locationYMargin);
                    else
                        location = new System.Drawing.Point(6, 21);

                    panel.Location = location;
                    this.Controls.Add(panel);
                    propertyPanels.Add(panel);
                }
            }
        }
    }
}
