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
using ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses.DataTypedDataTemplates;
using System.Collections.ObjectModel;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding
{
    /// <summary>
    /// Interaction logic for DataTypedDataTemplates.xaml
    /// </summary>
    public partial class DataTypedDataTemplates : Window
    {
        public DataTypedDataTemplates()
        {
            InitializeComponent();

            DataContext = new ObservableCollection<Person> {
				new Person { Name = "Bart", Age = 10 },
				new Employee { Name = "Homer", Age = 45, Department = "Nuclear" },
				new Person { Name = "Marge", Age = 35 },
				new Employee { Name = "Lisa", Age = 12, Department = "Accounting" },
				new Person { Name = "Maggie", Age = 1 }
			};
        }
    }
}
