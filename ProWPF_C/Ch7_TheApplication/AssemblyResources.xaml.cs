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
using System.IO;
using System.Globalization;
using System.Windows.Resources;

namespace ProWPF_C.Ch7_TheApplication
{
    /// <summary>
    /// Interaction logic for AssemblyResources.xaml
    /// </summary>
    public partial class AssemblyResources : Window
    {
        public AssemblyResources()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri("ResourceImages/Winter.jpg", UriKind.Relative));

            Sound.Stop();
            Sound.Play();

        }
    }
}
