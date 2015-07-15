using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding
{
    /// <summary>
    /// Interaction logic for SingleObjectBinding.xaml
    /// </summary>
    public partial class SingleObjectBinding : Window
    {
        readonly Person _person;

        public SingleObjectBinding()
        {
            InitializeComponent();

            _person = new Person { Name = "Bart", Age = 10 };
            DataContext = _person;

        }


        private void OnChange(object sender, RoutedEventArgs e)
        {
            _person.Age++;
        }

    }
}
