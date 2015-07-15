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
    /// Interaction logic for xDependancyProperty.xaml
    /// </summary>
    public partial class xDependancyProperty : Window
    {
        public xDependancyProperty()
        {
            InitializeComponent();
        }


        private void OnChangeValue(object sender, RoutedEventArgs e)
        {
            _simple3.YearPublished++;
        }

    }
}
