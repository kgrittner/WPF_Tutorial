using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Controls;

namespace ProWPF_C.Ch2_Xaml
{
    class Program1 : Application
    {
        [STAThread()]
        static void Something()
        {
            Program1 app = new Program1();
            app.MainWindow = new CodeOnly();
            app.MainWindow.ShowDialog();
        }

    }
}
