using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel.Design;
using System.ComponentModel;

namespace CommunicateWithArduino
{
    /// <summary>
    /// Interaction logic for CustomBorderlessButton.xaml
    /// </summary>
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class CustomBorderlessButton : UserControl
    {
        private string button_title { get; set; }
        public CustomBorderlessButton(string button_title)
        {
            InitializeComponent();
            this.button_title = button_title;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            btn1.Content = button_title;
        }
    }
}
