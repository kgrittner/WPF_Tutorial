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

namespace ProWPF_C.Ch7_TheApplication
{
    /// <summary>
    /// Interaction logic for WindowTracker.xaml
    /// </summary>
    public partial class WindowTracker : Window
    {
        public WindowTracker()
        {
            InitializeComponent();
        }

        private void cmdCreate_Click(object sender, RoutedEventArgs e)
        {
            Document doc = new Document();
            doc.Owner = this;
            doc.Show();
            ((App)Application.Current).Documents.Add(doc);
        }

        private void cmdUpdate_Click(object sender, RoutedEventArgs e)
        {
            foreach (Document doc in ((App)Application.Current).Documents)
            {
                doc.SetContent("Refreshed at: " + 
                    DateTime.Now.ToLongTimeString() +  ".");
            }


        }




    }
}
