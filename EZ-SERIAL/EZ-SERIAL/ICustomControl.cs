using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommunicateWithArduino
{
    internal interface ICustomControl
    {
        void ApplyPropertyChanges(string key, List<CustomProperty> value);
        Dictionary<string, List<CustomProperty>> ReturnCustomControlPropertyDictionary();
        Dictionary<string, List<CustomEvent>> ReturnCustomEventPropertyDictionary();
        string ControlTitle();
    }
}
