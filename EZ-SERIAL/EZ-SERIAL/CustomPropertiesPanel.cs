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
        private Label propertyLabel;
        private Control propertyControl;
        public Point panelLocation { get; set; }
        public CustomPropertiesPanel(string propertyTitle, Control propertyControl)
        {
            propertyLabel = new Label();
            propertyLabel.Text = propertyTitle;
            this.propertyControl = propertyControl;

            this.Size = new Size(225, 42);
            this.BackColor = Color.Black;

            //The label's panel
            Panel propertyLabelPanel = new Panel();
            this.Controls.Add(propertyLabelPanel);
            propertyLabelPanel.Size = new Size(75, 36);
            propertyLabelPanel.Location = new Point(3, 3);
            propertyLabelPanel.BackColor = Color.Gray;

            //The label itself
            propertyLabelPanel.Controls.Add(propertyLabel);
            propertyLabel.Size = new Size(69, 18);
            propertyLabel.Location = new Point(3, 9);
            propertyLabel.AutoSize = true;
            propertyLabel.Font = new Font("Arial",10.2f,FontStyle.Bold);
            propertyLabel.ForeColor = Color.White;
            


            //The control's panel
            Panel propertyControlPanel = new Panel();
            this.Controls.Add(propertyControlPanel);
            propertyControlPanel.Size = new Size(138, 36);
            propertyControlPanel.Location = new Point(84, 3);
            propertyControlPanel.BackColor = Color.Gray;

            //The control itself
            propertyControlPanel.Controls.Add(propertyControl);
            propertyControl.Dock = DockStyle.Fill;
            propertyControl.ForeColor = Color.White;
            propertyControl.BackColor = Color.Gray;
        }
    }
}
