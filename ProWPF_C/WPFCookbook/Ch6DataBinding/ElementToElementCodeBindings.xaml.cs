using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding
{
    /// <summary>
    /// Interaction logic for ElementToElementCodeBindings.xaml
    /// </summary>
    public partial class ElementToElementCodeBindings : Window
    {
        public ElementToElementCodeBindings()
        {
            InitializeComponent();

            var binding = new Binding("Value");
            //			binding.Source = _slider;
            binding.ElementName = "_slider";
            _text.SetBinding(TextBlock.FontSizeProperty, binding);

        }
    }
}
