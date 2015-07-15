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
using System.Diagnostics;

namespace ProWPF_C.Ch6_Controls
{
    /// <summary>
    /// Interaction logic for PopupTest.xaml
    /// </summary>
    public partial class PopupTest : Window
    {
        public PopupTest()
        {
            InitializeComponent();
        }

        private void Run_MouseEnter(object sender, MouseEventArgs e)
        {
            popLink.IsOpen = true;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(((Hyperlink)sender).NavigateUri.ToString());
        }
    }
}
