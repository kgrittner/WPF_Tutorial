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

namespace ProWPF_C.ToKnow2000.Commands
{
    /// <summary>
    /// Interaction logic for DeterminIfButtonIsEnabled.xaml
    /// </summary>
    public partial class DeterminIfButtonIsEnabled : Window
    {
        public DeterminIfButtonIsEnabled()
        {
            InitializeComponent();

            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, Open_Executed, Open_CanExecute));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Close, Close_Executed, Close_CanExecute));
        }


        private bool isOpen = false;

        public void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Open");
            isOpen = true;
        }

        public void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isOpen;
        }

        public void Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Close");
            isOpen = false;
        }

        public void Close_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isOpen;
        }










    }
}
