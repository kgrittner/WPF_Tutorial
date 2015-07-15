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
using Microsoft.Win32;

namespace ProWPF_C.WPFCookbook.Ch4StandardControls
{
    /// <summary>
    /// Interaction logic for Images.xaml
    /// </summary>
    public partial class Images : Window
    {
        public Images()
        {
            InitializeComponent();
        }

        void OnOpenImage(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Images|*.jpg;*.gif;*.bmp;*.png";
            if (dlg.ShowDialog() == true)
            {
                try
                {
                    var bmp = new BitmapImage(new Uri(dlg.FileName, UriKind.Absolute));
                    _image.Source = bmp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

    }
}
