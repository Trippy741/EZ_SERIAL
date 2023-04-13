using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal class CustomProperty
    {
        public CustomProperty(string propertyName, Control PropertyControl)
        {
            this.propertyName = propertyName;
            this.propertyControl = propertyControl;
        }
        public string propertyName { get; set; }
        public Control propertyControl { get; set; }

        struct defaultPropertyValue<T>
        {
            public T value { get; set; }
        }
    }
}
