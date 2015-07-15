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
    /// Interaction logic for BindingToCollection.xaml
    /// </summary>
    public partial class BindingToCollection : Window
    {
        ObservableCollection<Person3> _people;

        public BindingToCollection()
        {
            InitializeComponent();

            _people = new ObservableCollection<Person3> {
				new Person3 { Name = "Bart", Age = 10 },
				new Person3 { Name = "Homer", Age = 45 },
				new Person3 { Name = "Marge", Age = 35 },
				new Person3 { Name = "Lisa", Age = 12 },
				new Person3 { Name = "Maggie", Age = 1 }
			};

            _list.ItemsSource = _people;
            DataContext = _people;
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            _people.Add(new Person3 { Name = "Moe", Age = 40 });
        }
    }
}
