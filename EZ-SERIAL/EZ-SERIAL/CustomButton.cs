using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal class CustomButton : Button
    {
        protected bool isDraggable = true;
        public CustomButton()
        {
            ControlExtension.Draggable(this, true);
            this.MouseUp += rightClickHandler;
        }
        private void ToggleDraggable()
        {
            isDraggable = !isDraggable;
            ControlExtension.Draggable(this, isDraggable);
        }
        private void openContextMenu()
        {
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add("Delete");
            menu.Show(this,new System.Drawing.Point(this.Width / 2,this.Height / 2));//Creating the context menu in the middle of the control
        }
        private void rightClickHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                openContextMenu();
            }
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {

            base.OnPaint(pevent);
        }
    }
}
