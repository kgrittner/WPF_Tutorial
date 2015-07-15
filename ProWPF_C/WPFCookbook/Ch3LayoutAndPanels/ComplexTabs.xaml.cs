using ProWPF_C.WPFCookbook.Ch1Foundations.xClasses;
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

namespace ProWPF_C.WPFCookbook.Ch3LayoutAndPanels
{
    /// <summary>
    /// Interaction logic for ComplexTabs.xaml
    /// </summary>
    public partial class ComplexTabs : Window
    {
        public ComplexTabs()
        {
            InitializeComponent();

            _tabs.ItemsSource = new List<DataItem> {
				new DataItem { Header = "Header 1", Text = "Data 1 " },
				new DataItem { Header = "Header 2", Text = "Data 2 " },
				new DataItem { Header = "Header 3", Text = "Data 3 " },
			};

        }
    }
}
