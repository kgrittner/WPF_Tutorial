using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using ProWPF_C.Ch19_Databinding.Classes;

namespace ProWPF_C.Ch20_Databinding
{
    /// <summary>
    /// Interaction logic for VariedStyles.xaml
    /// </summary>
    public partial class VariedStyles : Window
    {
        public VariedStyles()
        {
            InitializeComponent();
        }


        private ICollection<Product> products;

        private void cmdGetProducts_Click(object sender, RoutedEventArgs e)
        {
            products = App.StoreDb.GetProducts();
            lstProducts.ItemsSource = products;
        }

        private void cmdApplyChange_Click(object sender, RoutedEventArgs e)
        {
            ((ObservableCollection<Product>)products)[1].CategoryName = "Travel";
            StyleSelector selector = lstProducts.ItemContainerStyleSelector;
            lstProducts.ItemContainerStyleSelector = null;
            lstProducts.ItemContainerStyleSelector = selector;
        }





    }
}
