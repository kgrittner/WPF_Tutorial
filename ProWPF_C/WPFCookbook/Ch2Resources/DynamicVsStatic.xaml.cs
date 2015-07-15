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
    /// Interaction logic for DynamicVsStatic.xaml
    /// </summary>
    public partial class DynamicVsStatic : Window
    {
        public DynamicVsStatic()
        {
            InitializeComponent();
        }

        // HOW IT WORKS

        // The DynamicResource markup extension binds to a resource dynamically,
        // which means that if the object itself is replaced with a new object (with the same key),
        // the new resource is used.

        // StaticResource bound properties keep referencing the old object.

        // This dynamic behavior allows for interesting effects.
        // For instance themes can be changed by swapping resources as long as the keys are the same.


        void OnReplaceBrush(object sender, RoutedEventArgs e)
        {
            var brush = new RadialGradientBrush();
            brush.GradientStops.Add(new GradientStop(Colors.Blue, 0));
            brush.GradientStops.Add(new GradientStop(Colors.White, 1));
            this.Resources["brush1"] = brush;
        }






    }
}
