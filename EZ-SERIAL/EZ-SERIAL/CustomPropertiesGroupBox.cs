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
        public CustomPropertiesGroupBox(string groupBoxText)
        {
            this.AutoSize = true;
            this.Dock = DockStyle.Top;
            this.Text = groupBoxText;
        }
        public void AddCustomPropertyPanel()
        {
            System.Drawing.Point location;
            CustomPropertiesPanel panel = new CustomPropertiesPanel("Text", new ComboBox());

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
