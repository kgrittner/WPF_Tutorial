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
using System.Text.RegularExpressions;

namespace ProWPF_C.MiscSources.WPFTutorialNet.Controls
{
    /// <summary>
    /// Interaction logic for TextBoxCon.xaml
    /// </summary>
    public partial class TextBoxCon : Window
    {


        public TextBoxCon()
        {
            InitializeComponent();
            //txtVal.AddHandler(TextBox.TextInputEvent,
            //       new TextCompositionEventHandler(OnTextInput,  true);
        }


        protected override void OnTextInput(TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, "a"))
            {
                e.Handled = true;
                MessageBox.Show("1");
            }
            else
            {
                MessageBox.Show("2");
            }
        }

    }



    
}
