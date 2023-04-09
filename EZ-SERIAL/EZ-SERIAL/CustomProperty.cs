using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal class CustomProperty
    {
        public CustomProperty()
        {
            if(propertyControl != null)
                propertyControl.TextChanged += controlTextChangedHandler;
        }
        private void controlTextChangedHandler(object sender, EventArgs e)
        {
            //
        }
        public string propertyName { get; set; }
        public Control propertyControl { get; set; }

        struct defaultPropertyValue<T>
        {
            public T value { get; set; }
        }
    }
}
