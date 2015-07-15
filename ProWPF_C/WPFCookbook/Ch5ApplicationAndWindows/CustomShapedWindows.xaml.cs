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

namespace ProWPF_C.WPFCookbook.Ch5ApplicationAndWindows
{
    /// <summary>
    /// Interaction logic for CustomShapedWindows.xaml
    /// </summary>
    public partial class CustomShapedWindows : Window
    {
        public CustomShapedWindows()
        {
            InitializeComponent();
        }

        private void OnMove(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
