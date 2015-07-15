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
    /// Interaction logic for ManagingLogicalResources.xaml
    /// </summary>
    public partial class ManagingLogicalResources : Window
    {
        public ManagingLogicalResources()
        {
            InitializeComponent();

            // RESOURCE IS MERGED IN THE APP.Xaml
            // THIS MAKES THE RESOURCE AVAILABLE TO THE WHOLE PROJECT

        }
    }
}
