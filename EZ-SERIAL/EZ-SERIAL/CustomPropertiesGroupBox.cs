using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal class CustomPropertiesGroupBox : GroupBox
    {
        private int locationYMargin = 50;
        public List<CustomPropertiesPanel> propertyPanels = new List<CustomPropertiesPanel>();

        private CustomButton.propertyChangeApply callbackDelegate;
        private List<CustomProperty> customPropertyList;

        public CustomPropertiesGroupBox(CustomButton.propertyChangeApply callbackDelegate, string groupBoxTitle, List<CustomProperty> customPropertyList)
        {
            this.callbackDelegate = callbackDelegate;
            this.customPropertyList = customPropertyList;

            foreach (CustomProperty property in customPropertyList)
            {
                propertyPanels.Add(new CustomPropertiesPanel(property));
            }
            this.AutoSize = true;
            //this.Dock = DockStyle.Top;
            this.Text = groupBoxTitle;
            spaceApartPropertyPanels();
            SetCustomOnChangeEvent();
        }
        public void SetCustomOnChangeEvent()
        {
            foreach (CustomPropertiesPanel panel in propertyPanels)
            {
                if (panel.propertyControl is TextBox)
                {
                    TextBox panelTextBox = (TextBox)panel.propertyControl;
                    panelTextBox.TextChanged += customTextBoxControl_TextChanged;
                }
                if (panel.propertyControl is CheckBox)
                {
                    CheckBox panelCheckBox = (CheckBox)panel.propertyControl;
                    panelCheckBox.CheckedChanged += customCheckBoxControl_TextChanged;
                }
            }
            callbackDelegate(this.Text,customPropertyList);
        }
        private void customTextBoxControl_TextChanged(object sender, EventArgs e)
        {
            TextBox senderTextBox = (TextBox)sender;
            foreach (CustomProperty customProperty in customPropertyList)
            {
                TextBox customPropertyTextBox = (TextBox)customProperty.propertyControl;
                if (customPropertyTextBox == sender)
                    customPropertyTextBox.Text = senderTextBox.Text;
            }

            //Change the custom properties within the list
            //So that the callback function could bring those values back to the custom button
        }
        private void customCheckBoxControl_TextChanged(object sender, EventArgs e)
        {
            CheckBox senderCheckBox = (CheckBox)sender;
            foreach (CustomProperty customProperty in customPropertyList)
            {
                CheckBox customPropertyCheckBox = (CheckBox)customProperty.propertyControl;
                if (customPropertyCheckBox == sender)
                    customPropertyCheckBox.Checked = senderCheckBox.Checked;
            }
        }
        public void spaceApartPropertyPanels()
        {
            if (propertyPanels.Count > 0)
            {
                List<CustomPropertiesPanel> panels = new List<CustomPropertiesPanel>();
                panels.AddRange(propertyPanels);
                foreach (CustomPropertiesPanel panel in panels)
                {
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
