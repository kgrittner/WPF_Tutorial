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
using ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses.ValidatingData;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding
{
    /// <summary>
    /// Interaction logic for ValidatingData.xaml
    /// </summary>
    public partial class ValidatingData : Window
    {
        public ValidatingData()
        {
            InitializeComponent();

            DataContext = new Person { Name = "Bart", Age = 10 };
        }
    }
}
