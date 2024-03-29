﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal class CustomTimerControl : Label , ICustomControl
    {
        public Dictionary<string, List<CustomProperty>> customPropertyDictionary = new Dictionary<string, List<CustomProperty>>();
        public void ApplyPropertyChanges(string key, List<CustomProperty> value)
        {
            //Apply all changes to button design and functions
            if (key == "Appearance")
            {
                /*this.Text = customPropertyList[0].propertyControl.Text;
                this.BackColor = customPropertyList[1].propertyControl.BackColor;
                this.ForeColor = customPropertyList[2].propertyControl.ForeColor;*/

                //string[] split_size = customPropertyList[3].propertyControl.Text.Split(',');
                //this.Size = new Size(int.Parse(split_size[0]), int.Parse(split_size[1]));
            }

        }

        public string ControlTitle()
        {
            //return customPropertyList[0].propertyControl.Text;
            return "Timer";
        }

        public Dictionary<string, List<CustomProperty>> ReturnCustomControlPropertyDictionary()
        {
            return customPropertyDictionary;
        }

        public Dictionary<string, List<CustomEvent>> ReturnCustomEventPropertyDictionary()
        {
            throw new NotImplementedException();
        }
    }
}
