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
using ProWPF_C.MiscSources.WPFTutorialNet.Classes;

namespace ProWPF_C.MiscSources.WPFTutorialNet.Controls
{
    /// <summary>
    /// Interaction logic for ColorPicker.xaml
    /// </summary>
    public partial class ColorPicker : Window
    {

        public IEnumerable<Brush> TestData
        {
            get
            {
                yield return new SolidColorBrush(Colors.Red);
                yield return new SolidColorBrush(Colors.Orange);
                yield return new SolidColorBrush(Colors.Yellow);
                yield return new SolidColorBrush(Colors.YellowGreen);
                yield return new SolidColorBrush(Colors.LightGreen);
                yield return new SolidColorBrush(Colors.Green);
                yield return new SolidColorBrush(Colors.LightBlue);
            }
        }

        public ColorPicker()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
