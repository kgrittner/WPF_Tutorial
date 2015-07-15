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

namespace ProWPF_C.WPFCookbook.Ch5ApplicationAndWindows
{
    /// <summary>
    /// Interaction logic for Dialogs.xaml
    /// </summary>
    public partial class Dialogs : Window
    {
        public Dialogs()
        {
            InitializeComponent();
        }

        private void OnEnterData(object sender, RoutedEventArgs e)
        {
            var dlg = new DetailsDialog();
            if (dlg.ShowDialog() == true)
            {
                _text.Text = string.Format("Hi, {0}! I see you live in {1}.",
                    dlg.FullName, dlg.City);
            }
        }

    }
}
