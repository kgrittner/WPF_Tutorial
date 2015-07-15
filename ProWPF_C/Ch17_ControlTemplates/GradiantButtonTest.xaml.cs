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

namespace ProWPF_C.Ch17_ControlTemplates
{
    /// <summary>
    /// Interaction logic for GradiantButtonTest.xaml
    /// </summary>
    public partial class GradiantButtonTest : Window
    {
        public GradiantButtonTest()
        {
            InitializeComponent();
        }


        private void Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked " + ((Button)sender).Name);
        }


        private void chkGreen_Checked(object sender, RoutedEventArgs e)
        {
            ResourceDictionary resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri(
              "Ch17_ControlTemplates/Resources_Ch17/GradiantButtonVariant.xaml", UriKind.Relative);
            this.Resources.MergedDictionaries[0] = resourceDictionary;
        }

        private void chkGreen_Unchecked(object sender, RoutedEventArgs e)
        {
            ResourceDictionary resourceDictionary = new ResourceDictionary();
            resourceDictionary.Source = new Uri(
              "Ch17_ControlTemplates/Resources_Ch17/GradiantButton.xaml", UriKind.Relative);
            this.Resources.MergedDictionaries[0] = resourceDictionary;
        }



    }
}
