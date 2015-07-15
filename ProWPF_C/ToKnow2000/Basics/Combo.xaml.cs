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
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Combo : Window
    {
        // #204 – Detecting Key Presses in a WPF Window
        private static Key[] vowels = {Key.A, Key.E, Key.I, Key.O, Key.U};

        public Combo()
        {
            InitializeComponent();
        }

        // #204 – Detecting Key Presses in a WPF Window
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if ((vowels.Contains(e.Key)) && (!e.IsRepeat))
                lblVowels.Content = lblVowels.Content + e.Key.ToString();
        }

        // #204 – Detecting Key Presses in a WPF Window
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (vowels.Contains(e.Key))
                lblVowels.Content = lblVowels.Content + ",";
        }









        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Blank win = new Blank();
            win.Title = DateTime.Now.ToLongTimeString();
            win.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Window w in App.Current.Windows)
            {
                sb.AppendFormat("Window [{0}] is at ({1},{2}).\n", w.Title, w.Top, w.Left);
            }

            MessageBox.Show(sb.ToString(), "My Windows");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Combo w = new Combo();
            w.Title = string.Format("Child #{0}", this.OwnedWindows.Count + 1);
            w.Owner = this;
            w.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Combo win = new Combo();
            win.Title = "Modal child - " + DateTime.Now.ToLongTimeString();
            win.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Combo win = new Combo();
            win.Title = "Modeless window - " + DateTime.Now.ToLongTimeString();
            win.Show();
        }
    }
}
