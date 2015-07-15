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

namespace ProWPF_C.WPFCookbook.Ch2Resources
{
    /// <summary>
    /// Interaction logic for UserSelectedColorsFonts.xaml
    /// </summary>
    public partial class UserSelectedColorsFonts : Window
    {
        public UserSelectedColorsFonts()
        {
            InitializeComponent();
        }

        // To use this go to:
        // 1) Control Panel
        // 2) Personalization
        // 3) Themes & change theme to Classic

        // You will see the color and font change as
        // it is bound to the system settings


    }
}
