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
        public List<CustomProperty> appearanceProperties = new List<CustomProperty>();
        public CustomButton()
        {
            ControlExtension.Draggable(this, true);
            this.MouseUp += rightClickHandler;

            //Button Text Property
            CustomProperty buttonTextProperty = new CustomProperty();
            buttonTextProperty.propertyName = "Button Text";
            buttonTextProperty.propertyControl = new Label();
            appearanceProperties.Add(buttonTextProperty);

            //Background color property
            CustomProperty bgColorProperty = new CustomProperty();
            bgColorProperty.propertyName = "BG Color";
            bgColorProperty.propertyControl = new Panel();
            appearanceProperties.Add(bgColorProperty);

            //Foreground color property
            CustomProperty fgColorProperty = new CustomProperty();
            fgColorProperty.propertyName = "FG Color";
            fgColorProperty.propertyControl = new Panel();
            appearanceProperties.Add(fgColorProperty);

            //Size property
            CustomProperty sizeProperty = new CustomProperty();
            sizeProperty.propertyName = "Size (X,Y)";
            sizeProperty.propertyControl = new TextBox();
            appearanceProperties.Add(sizeProperty);
        }
        public void ToggleDraggable()
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
    }
}
