using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProWPF_C.ToKnow2000.Basics
{
    /// <summary>
    /// Interaction logic for Unhandled_Exceptions.xaml
    /// </summary>
    public partial class Unhandled_Exceptions : Window
    {
        public Unhandled_Exceptions()
        {
            InitializeComponent();
        }

        

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            string friendlyMsg = string.Format("SO sorry that something went wrong.  The error was: [{0}]", e.Exception.Message);
            string caption = "Error";
            MessageBox.Show(friendlyMsg, caption, MessageBoxButton.OK, MessageBoxImage.Error);

            // Signal that we handled things--prevents Application from exiting
            e.Handled = true;
        }
    }
}
