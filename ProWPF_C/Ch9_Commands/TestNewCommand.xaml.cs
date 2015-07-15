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

namespace ProWPF_C.Ch9_Commands
{
    /// <summary>
    /// Interaction logic for TestNewCommand.xaml
    /// </summary>
    public partial class TestNewCommand : Window
    {
        public TestNewCommand()
        {
            InitializeComponent();
        }


        private void NewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New command triggered by " + e.Source.ToString());
        }

        private void cmdDoCommand_Click(object sender, RoutedEventArgs e)
        {
            this.CommandBindings[0].Command.Execute(null);
            // ApplicationCommands.New.Execute(null, (Button)sender);
        }


    }
}
