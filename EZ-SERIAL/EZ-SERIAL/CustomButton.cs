using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal class CustomButtonControl : Button , ICustomControl
    {
        protected bool isDraggable = true;
        private List<CustomProperty> customPropertyList = new List<CustomProperty>();
        public Dictionary<string, List<CustomProperty>> customPropertyDictionary = new Dictionary<string, List<CustomProperty>>();
        //public List<CustomProperty> appearanceProperties = new List<CustomProperty>();
        public CustomButtonControl()
        {
            ControlExtension.Draggable(this, true);
            this.MouseUp += rightClickHandler;
            this.AutoSize = true;


            //Button Text Property
            CustomProperty buttonTextProperty = new CustomProperty("Button Text", new TextBox());
            TextBox tempTextBoxText = (TextBox)buttonTextProperty.propertyControl;
            tempTextBoxText.Text = "Button";
            customPropertyList.Add(buttonTextProperty);

            //Background color property
            CustomProperty bgColorProperty = new CustomProperty("BG Color", new Panel());
            customPropertyList.Add(bgColorProperty);

            //Foreground color property
            CustomProperty fgColorProperty = new CustomProperty("FG Color", new Panel());
            customPropertyList.Add(fgColorProperty);

            //Size property
            CustomProperty sizeProperty = new CustomProperty("Size (X,Y)", new TextBox());
            TextBox tempTextBoxSize = (TextBox)sizeProperty.propertyControl;
            tempTextBoxSize.Text = "75,23";
            customPropertyList.Add(sizeProperty);

            customPropertyDictionary.Add("Appearance",customPropertyList);
            ApplyPropertyChanges("Appearance",customPropertyList);
        }
        public void ApplyPropertyChanges(string key, List<CustomProperty> value)
        {
            //Apply all changes to button design and functions
            if (key == "Appearance")
            {
                this.Text = customPropertyList[0].propertyControl.Text;
                this.BackColor = customPropertyList[1].propertyControl.BackColor;
                this.ForeColor = customPropertyList[2].propertyControl.ForeColor;

                string[] split_size = customPropertyList[3].propertyControl.Text.Split(',');
                this.Size = new Size(int.Parse(split_size[0]), int.Parse(split_size[1]));
            }

        }
        public void ToggleDraggable()
        {
            isDraggable = !isDraggable;
            ControlExtension.Draggable(this, isDraggable);
        }
        private void openContextMenu()
        {
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add(new MenuItem("Delete",deleteButtonHandler));
            menu.Show(this,new System.Drawing.Point(this.Width / 2, this.Height / 2));//Creating the context menu in the middle of the control
        }
        private void deleteButtonHandler(object sender, EventArgs e)
        {
            this.Dispose();
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
