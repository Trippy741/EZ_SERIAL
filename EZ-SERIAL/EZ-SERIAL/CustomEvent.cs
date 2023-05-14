using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunicateWithArduino
{
    internal class CustomEvent
    {
        public string EventTitle { get; set; }
        //public delegate void eventLink();
        //public eventLink EventLink;
        public CustomEvent()
        {
            //EventLink = new eventLink(invokeEventLink);
        }

        public void invokeEventLink(object sender, EventArgs e)
        {
            MessageBox.Show("Event triggered and it finally works!!!!");
        }
    }
}
