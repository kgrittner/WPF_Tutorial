using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Reflection;

namespace ProWPF_C
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow :Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Expander_Click(object sender, RoutedEventArgs e)
        {
            // The content extender will trigger from the Button.Click on the stack panel
            // So we need to figure out if it's the button calling or the expander
            // If it is not a button it will fail on     Button cmd = etc..

            try
            {
                // Get the current button
                Button cmd = (Button)e.OriginalSource;

                // Create an instance of the window named by the current button
                Type type = this.GetType();
                Assembly assembly = type.Assembly;

                // Gets the tag from the calling StackPanel
                object expanderTag = ((FrameworkElement)sender).Tag;

                Window win = (Window)assembly.CreateInstance(type.Namespace + "." + expanderTag + "." + cmd.Content);
                win.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void CodeOnly_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestWindow1 testW = new TestWindow1();
            testW.Show();
        }














    } // END Class
}
