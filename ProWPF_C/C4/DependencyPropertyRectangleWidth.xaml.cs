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

namespace ProWPF_C.C4
{
    /// <summary>
    /// Interaction logic for DependencyPropertyRectangleWidth.xaml
    /// </summary>
    public partial class DependencyPropertyRectangleWidth : Window
    {
        public EventHandler _WidthChanged;
        public int mcount;

        public DependencyPropertyRectangleWidth()
        {
            InitializeComponent();
            _WidthChanged += new EventHandler(DependencyPropertyRectangleWidth__WidthChanged);
        }

        void DependencyPropertyRectangleWidth__WidthChanged(object sender, EventArgs e)
        {
            mcount += 1;
            lblSideLabel.Content = "Something" + mcount.ToString();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            red_rectangle.Width += 20;
            Rectangle temp;
        }

        private void Detach_Click(object sender, RoutedEventArgs e)
        {
            DependencyPropertyDescriptor dp;
            dp = DependencyPropertyDescriptor.FromProperty(
                Rectangle.WidthProperty, typeof(Rectangle));

            dp.RemoveValueChanged(red_rectangle, _WidthChanged);
        }

        private void Attach_Click(object sender, RoutedEventArgs e)
        {
            DependencyPropertyDescriptor dp;
            dp = DependencyPropertyDescriptor.FromProperty(
                Rectangle.WidthProperty, typeof(Rectangle));

            dp.AddValueChanged(red_rectangle, _WidthChanged);
        }



        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            lblSideLabel.Content = "RESET STATIC";
        }


        // END
    }
}
