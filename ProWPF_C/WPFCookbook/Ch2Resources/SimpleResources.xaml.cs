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
    /// Interaction logic for SimpleResources.xaml
    /// </summary>
    public partial class SimpleResources : Window
    {
        public SimpleResources()
        {
            InitializeComponent();
        }

        private void OnModifyBrush(object sender, RoutedEventArgs e)
        {
            // 3)
            // MODIFYING RESOURCES

            // All {StaticResource} (or FindResource) lookups with a specific key
            // use the same object instance. This mean that modifuing the resource 
            // properties (not replacing the resource with a different one), 
            // impacts automatically all properties using that resource. 
            // For exampleif we modifu the brush resource as follows:
            var brush = (LinearGradientBrush)this.Resources["brush1"];
            brush.GradientStops.Add(new GradientStop(Colors.Blue, .5));


            //The same lookup effect can be achieved in code by 
            //using the FrameworkElement FindResource method as follows:
            Brush brush2 = (Brush)this.FindResource("brush1");


            // 1)
            // IF RESOURCE NOT FOUND NO ERROR

            // This has the same effect as using {StaticResources}. 
            // If an exception is undesirable in case of a non-existent resource, 
            // the TryFindResource can be used instead.
            Brush brush3 = (Brush)this.TryFindResource("brush1");
            if (brush3 == null) 
            { 
                // Not Found DO SOMETHING 
            }



            // 2)
            // ADDING OR DELETING RESOURCES DYNAMICALLY

            // The Resources dictionary can be manipulated at runtime,
            // by adding or removing resources. Here's how to add a new resource:
            this.Resources.Add("brush2", new SolidColorBrush(Color.FromRgb(200, 10, 150)));

        }




    } // END Class
}
