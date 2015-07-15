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

namespace ProWPF_C.Ch8_ElementBinding
{
    /// <summary>
    /// Interaction logic for ElementToElementBinding.xaml
    /// </summary>
    public partial class ElementToElementBinding : Window
    {

        public string someString2 = "Bound programmatically";

        public ElementToElementBinding()
        {
            InitializeComponent();
        }

        private void cmdSetSmall_Click(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 2;
        }

        private void cmdSetNormal_Click(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = this.FontSize;
        }

        private void cmdSetLarge_Click(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 30;
        }

        private void cmd_GetBoundObject(object sender, RoutedEventArgs e)
        {
            Binding binding = BindingOperations.GetBinding(txtBound, TextBox.TextProperty);
            MessageBox.Show("Bound " + binding.Path.Path + " to source element "
                + binding.ElementName);

            BindingExpression expression = BindingOperations.GetBindingExpression(
                txtBound, TextBox.TextProperty);
            MessageBox.Show("Bound " + expression.ResolvedSourcePropertyName
                + " with data " + ((TextBlock)expression.ResolvedSource).FontSize);


            Binding myBinding = new Binding();
            myBinding.Source = ViewModel; // x:Name="ViewModel"
            myBinding.Path = new PropertyPath("SomeString");
            myBinding.FallbackValue = "Fallback if you see this then something went wrong";
            myBinding.Mode = BindingMode.OneWay;
            //myBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            BindingOperations.SetBinding(myText, TextBox.TextProperty, myBinding);


            
        }

        public string SomeString
        {
            get{ return someString2; }
            // IF SET you must have Mode=TwoWay
            //set
            //{
            //    someString2 = value;
            //}
        }

       

    }
}
