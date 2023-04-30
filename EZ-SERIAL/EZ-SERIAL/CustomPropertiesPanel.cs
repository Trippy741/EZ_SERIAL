using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal class CustomPropertiesPanel : Panel
    {
        public Label propertyLabel { get; }
        public Control propertyControl;
        public CustomProperty customProperty { get; }
        public Point panelLocation { get; set; }
        public CustomPropertiesPanel(CustomProperty customProperty)
        {
            this.customProperty = customProperty;
            propertyLabel = new Label();
            propertyLabel.Text = customProperty.propertyName;
            this.propertyControl = customProperty.propertyControl;

            this.Size = new Size(225, 42);
            this.BackColor = Color.White;

            //The label's panel
            Panel propertyLabelPanel = new Panel();
            this.Controls.Add(propertyLabelPanel);
            propertyLabelPanel.Size = new Size(75, 36);
            //propertyLabelPanel.AutoSize = true;
            propertyLabelPanel.Location = new Point(3, 3);
            propertyLabelPanel.BackColor = Color.Gray;

            //The label itself
            propertyLabelPanel.Controls.Add(propertyLabel);
            propertyLabel.Location = new Point(3, 9);
            propertyLabel.AutoSize = true;
            propertyLabel.Font = new Font("Arial",9f,FontStyle.Bold);
            propertyLabel.ForeColor = Color.Black;
            


            //The control's panel
            Panel propertyControlPanel = new Panel();
            this.Controls.Add(propertyControlPanel);
            propertyControlPanel.Size = new Size(138, 36);
            propertyControlPanel.Location = new Point(84, 3);
            propertyControlPanel.BackColor = Color.Gray;

            //The control itself
            propertyControlPanel.Controls.Add(propertyControl);
            propertyControl.Dock = DockStyle.Fill;
            propertyControl.ForeColor = Color.Black;
            //propertyControl.BackColor = Color.Gray;
            //TODO: This line here is creating a problem
            //Because it resets the color of the control's bg everytime
            //You create it and if you happen to use it to actually store a color...
            //It ends up overwriting it.
        }
    }
}
