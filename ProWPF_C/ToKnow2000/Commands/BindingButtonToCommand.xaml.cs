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
using System.IO;

namespace ProWPF_C.ToKnow2000.Commands
{
    /// <summary>
    /// Interaction logic for BindingButtonToCommand.xaml
    /// </summary>
    public partial class BindingButtonToCommand : Window
    {
        public Boolean bln = false;
        public string fileLocation = @"C:\Users\KarlFast\Documents\Visual Studio 2012\Projects\ProWPF_C\ProWPF_C\ToKnow2000\Commands\testFile.txt";

        public BindingButtonToCommand()
        {
            InitializeComponent();

            // Runs 2 steps in sequence 
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, Open_Executed, Open_CanExecute));
        }


        public void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            try { 
               var myFile = File.Open(fileLocation, FileMode.Open);
                myFile.Close();
            }
            catch (Exception) 
            {
                MessageBox.Show("First file open failed... Check Path");

            }


            try
            {
                using (StreamWriter sw = File.AppendText(@"C:\Users\KarlFast\Documents\Visual Studio 2012\Projects\ProWPF_C\ProWPF_C\ToKnow2000\Commands\testFile.txt"))
                {
                    sw.WriteLine("Wrote a new line: " + DateTime.Now.ToLongTimeString());
                    MessageBox.Show("Wrote Line to text file");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
                //throw;
            }



        }

        public void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;   // Can we open file?
            txtCanExTracker.Text += "Can Execute = True... If we could not write to the text file it would be false" + Environment.NewLine;
        }













    }
}
