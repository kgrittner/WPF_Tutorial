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
using System.Collections.ObjectModel;
using ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding
{
    /// <summary>
    /// Interaction logic for DataTemplates.xaml
    /// </summary>
    public partial class DataTemplates : Window
    {
        public DataTemplates()
        {
            InitializeComponent();

            DataContext = new Person4 { Age = 10, Name = "Bart" };

            _list.ItemsSource = new ObservableCollection<Person4> {
				new Person4 { Name = "Bart", Age = 10 },
				new Person4 { Name = "Homer", Age = 45 },
				new Person4 { Name = "Marge", Age = 35 }
			};
        }
    }
}
