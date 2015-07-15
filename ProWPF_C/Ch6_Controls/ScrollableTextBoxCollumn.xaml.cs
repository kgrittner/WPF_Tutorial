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

namespace ProWPF_C.Ch6_Controls
{
    /// <summary>
    /// Interaction logic for ScrollableTextBoxCollumn.xaml
    /// </summary>
    public partial class ScrollableTextBoxCollumn : Window
    {
        public ScrollableTextBoxCollumn()
        {
            InitializeComponent();
        }

        private void LineUp(object sender, RoutedEventArgs e)
        {
            scroller.LineUp();
        }
        private void LineDown(object sender, RoutedEventArgs e)
        {
            scroller.LineDown();
        }
        private void PageUp(object sender, RoutedEventArgs e)
        {
            scroller.PageUp();
        }
        private void PageDown(object sender, RoutedEventArgs e)
        {
            scroller.PageDown();
        }
    }
}
