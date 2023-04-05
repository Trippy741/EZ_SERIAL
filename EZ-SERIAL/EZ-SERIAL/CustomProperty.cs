using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal struct CustomProperty
    {
        public string propertyName { get; set; }
        public Control propertyControl { get; set; }

        struct defaultPropertyValue<T>
        {
            public T value { get; set; }
        }
    }
}
