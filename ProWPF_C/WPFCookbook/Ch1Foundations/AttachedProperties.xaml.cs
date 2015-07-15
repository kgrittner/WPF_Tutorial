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

namespace ProWPF_C.WPFCookbook.Ch1Foundations
{
    /// <summary>
    /// Interaction logic for AttachedProperties.xaml
    /// </summary>
    public partial class AttachedProperties : Window
    {
        public AttachedProperties()
        {
            InitializeComponent();
        }

        private void OnMove(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(_rect, Canvas.GetLeft(_rect) + 5);
            // alternatively:
            //_rect.SetValue(Canvas.LeftProperty, (double)_rect.GetValue(Canvas.LeftProperty) + 5);
        }


    }
}
