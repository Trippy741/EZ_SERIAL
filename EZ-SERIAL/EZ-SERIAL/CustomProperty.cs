using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal class CustomProperty<T>
    {
        public T Value { get; set; }
        public CustomProperty(string propertyName, Control propertyControl)
        {
            this.propertyName = propertyName;
            this.propertyControl = propertyControl;
        }
        public string propertyName { get; set; }
        public Control propertyControl { get; set; }
    }
}
