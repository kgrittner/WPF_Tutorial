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

namespace ProWPF_C.ToKnow2000.Basics
{
    /// <summary>
    /// Interaction logic for Templates.xaml
    /// </summary>
    public partial class Navigating_the_Logical_Tree_in_Code : Window
    {
        public Navigating_the_Logical_Tree_in_Code()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = "";
            MainWindow mw = new MainWindow();
            foreach (Object obj in LogicalTreeHelper.GetChildren(mw.gridMain as DependencyObject))
            {
                txtBlock.Text += obj.ToString() + Environment.NewLine;

                foreach (Object obj2 in LogicalTreeHelper.GetChildren(obj as DependencyObject))
                {
                    txtBlock.Text += " ----> "+ obj2.ToString() + Environment.NewLine;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = "";
            MainWindow mw = new MainWindow();
            foreach (Object obj in LogicalTreeHelper.GetChildren(mw.stpToKnow as DependencyObject))
            {
                txtBlock.Text += obj.ToString() + Environment.NewLine;
                
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = "";
            MainWindow mw = new MainWindow();
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(mw.stpToKnow); i++)
                txtBlock.Text += VisualTreeHelper.GetChild(mw.stpToKnow, i) + Environment.NewLine;
        }
    }
}
