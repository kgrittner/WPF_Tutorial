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
using System.ComponentModel;

namespace ProWPF_C.Ch5_RoutedEvents
{
    /// <summary>
    /// Interaction logic for Ch5RoutedEvents.xaml
    /// </summary>
    public partial class RoutedEvents : Window
    {

        

        public RoutedEvents()
        {
            InitializeComponent();

            #region The First Image
            img.AddHandler(UIElement.MouseUpEvent, new MouseButtonEventHandler(Image_MouseUp));
            //img.MouseUp += new MouseButtonEventHandler(Image_MouseUp);
            //img.MouseUp += Image_MouseUp;

            // REMOVE EVENT... If you uncomment this then there will no
            //                 MessageBox shown.
            //img.MouseUp -= Image_MouseUp;
            //img.RemoveHandler(UIElement.MouseUpEvent, new MouseButtonEventHandler(Image_MouseUp));
            #endregion 
        }

        #region The First Image

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Image_MouseUp Pressed");
        }

        private void img_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
        }

        private void img_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        #endregion

        // Good way to get attributes from the sender / calling node
        #region The Three Command 1 buttons


        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            Button cmd = (Button)e.OriginalSource;

            // Gets the tag from the calling StackPanel
            object tag = ((FrameworkElement)sender).Tag;
          

            MessageBox.Show("StackPanel Tag: " + (string)tag
                 + Environment.NewLine 
                 + "Button Name: " + cmd.Content);

            // Compare the source
            if (e.Source == cmd1)
            {
                // Do Something
            }
        }

        #endregion






    }
}
