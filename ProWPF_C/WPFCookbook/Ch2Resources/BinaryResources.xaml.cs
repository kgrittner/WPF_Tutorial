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

namespace ProWPF_C.WPFCookbook.Ch2Resources
{
    /// <summary>
    /// Interaction logic for BinaryResources.xaml
    /// </summary>
    public partial class BinaryResources : Window
    {
        public BinaryResources()
        {
            InitializeComponent();
            //	_image.Source = new BitmapImage(new Uri("Images/apple.png", UriKind.Relative));


            // If you place the jellyfish image without rebuilding the app 
            // it will pull up the new image

        }
    }
}
