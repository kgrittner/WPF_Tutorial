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
using System.Data;
using System.ComponentModel;

namespace ProWPF_C.Ch21_Databinding
{
    /// <summary>
    /// Interaction logic for FilterDataSet.xaml
    /// </summary>
    public partial class FilterDataSet : System.Windows.Window
    {

        public FilterDataSet()
        {
            InitializeComponent();
        }

        private DataTable products;

        private void cmdGetProducts_Click(object sender, RoutedEventArgs e)
        {
            products = App.StoreDbDataSet.GetProducts();
            lstProducts.ItemsSource = products.DefaultView;

            ICollectionView view = CollectionViewSource.GetDefaultView(lstProducts.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("ModelName", ListSortDirection.Ascending));
        }

        private void cmdFilter_Click(object sender, RoutedEventArgs e)
        {
            decimal minimumPrice;
            // Difference between Convert and TryParse is that if i sent 200s to convert it would fail (Throw ex)
            // But TryParse will return a Boolean
            // The out means that it will assign the result of TryParse to minimumPrice
            if (Decimal.TryParse(txtMinPrice.Text, out minimumPrice))
            {
                BindingListCollectionView view = CollectionViewSource.GetDefaultView(lstProducts.ItemsSource) as BindingListCollectionView;
                if (view != null)
                {
                    view.CustomFilter = "UnitCost > " + minimumPrice.ToString();
                }
            }
        }

        private void cmdRemoveFilter_Click(object sender, RoutedEventArgs e)
        {
            BindingListCollectionView view = CollectionViewSource.GetDefaultView(lstProducts.ItemsSource) as BindingListCollectionView;
            if (view != null)
            {
                view.CustomFilter = "";
            }
        }
    }        
}
