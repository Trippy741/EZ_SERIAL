using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CommunicateWithArduino
{
    internal class CustomControl : Control
    {
        public delegate void PropertyChangeCallback();
        public CustomControl()
        {
            
        }
    }
}
