using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommunicateWithArduino
{
    internal class CustomEvent : ICustomProperty
    {
        public string EventTitle { get; set; }
        public delegate void linkEvent();
        private linkEvent eventLink;
    }
}
