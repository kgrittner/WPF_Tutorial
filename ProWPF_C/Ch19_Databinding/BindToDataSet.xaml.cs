﻿using System;
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
using System.Data;
using ProWPF_C.Ch19_Databinding.Classes;

namespace ProWPF_C.Ch19_Databinding
{
    /// <summary>
    /// Interaction logic for BindToDataSet.xaml
    /// </summary>
    public partial class BindToDataSet : Window
    {
        public BindToDataSet()
        {
            InitializeComponent();
        }

        private DataTable products;

        private void cmdGetProducts_Click(object sender, RoutedEventArgs e)
        {
            products = App.StoreDbDataSet.GetProducts();
            lstProducts.ItemsSource = products.DefaultView;
        }

        private void cmdDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            ((DataRowView)lstProducts.SelectedItem).Row.Delete();
        }










    } // End Class
}
