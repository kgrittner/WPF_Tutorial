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
using ProWPF_C.Ch20_Databinding.Classes;
using ProWPF_C.Ch19_Databinding.Classes;

namespace ProWPF_C.Ch20_Databinding
{
    /// <summary>
    /// Interaction logic for RadioButtonList.xaml
    /// </summary>
    public partial class RadioButtonList : Window
    {
        public RadioButtonList()
        {
            InitializeComponent();

            lstProducts.ItemsSource = App.StoreDb.GetProducts();
        }


        private void cmdGetSelectedItem(object sender, RoutedEventArgs e)
        {
            string items = "You selected: ";
            foreach (Product product in lstProducts.SelectedItems)
            {
                items += "\n  * " + product.ModelNumber;
            }

            MessageBox.Show(items);
        }

    }
}
