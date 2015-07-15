using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Windows.Resources;
using System.Reflection;
using System.Resources;
using System.Globalization;
using System.IO;

namespace ProWPF_C.WPFCookbook.Ch2Resources
{
    /// <summary>
    /// Interaction logic for AccessingBinaryResourceInCode.xaml
    /// </summary>
    public partial class AccessingBinaryResourceInCode : Window
    {
        public AccessingBinaryResourceInCode()
        {
            InitializeComponent();
        }



        private void OnReadData(object sender, RoutedEventArgs e)
        {
            var info = Application.GetResourceStream(new Uri(
                "WPFCookbook/Ch2Resources/Xml/books.xml", UriKind.Relative));
            var books = XElement.Load(info.Stream);
            var bookList = from book in books.Elements("Book")
                           orderby (string)book.Attribute("Author")
                           select new
                           {
                               Name = (string)book.Attribute("Name"),
                               Author = (string)book.Attribute("Author")
                           };
            foreach (var book in bookList)
                _text.Text += book + Environment.NewLine;
        }


        // ALTERNATE WAY OF DOING ABOVE CODE

        //Stream GetResourceStream(string name)
        //{
        //    string asmName = Assembly.GetExecutingAssembly().GetName().Name;
        //    var rm = new ResourceManager(asmName + ".g", Assembly.GetExecutingAssembly());
        //    using (var set = rm.GetResourceSet(CultureInfo.CurrentCulture, true, true))
        //    {
        //        return (Stream)set.GetObject(name, true);
        //    }
        //}




    }
}
