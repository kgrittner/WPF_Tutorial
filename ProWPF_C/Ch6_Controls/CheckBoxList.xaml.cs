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

namespace ProWPF_C.Ch6_Controls
{
    /// <summary>
    /// Interaction logic for CheckBoxList.xaml
    /// </summary>
    public partial class CheckBoxList : Window
    {
        public CheckBoxList()
        {
            InitializeComponent();
        }

        private void lst_SelectionChanged(object sender, RoutedEventArgs e)
        {

            if (e.OriginalSource is CheckBox)
            {
                lst.SelectedItem = e.OriginalSource;
            }

            if (lst.SelectedItem == null) return;

            txtSelection.Text = String.Format(
                "You chose item at position {0}.\r\nChecked state is {1}.",
                lst.SelectedIndex,
                ((CheckBox)lst.SelectedItem).IsChecked);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (CheckBox item in lst.Items)
            {
                if (item.IsChecked == true)
                {
                    sb.Append(item.Content + " is checked.");
                        sb.Append("\r\n");
                }
            }
            txtSelection.Text = sb.ToString();
        }
    }
}
