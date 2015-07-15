using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.IO;

namespace ProWPF_C.Ch20_Databinding.Classes
{
    public class ImagePathConverter : IValueConverter
    {
        //private string imageDirectory = Directory.GetCurrentDirectory();
        private string imageDirectory = @"C:\Users\KarlFast\Documents\Visual Studio 2012\Projects\ProWPF_C\ProWPF_C\Ch20_Databinding\Images\";
        public string ImageDirectory
        {
            get { return imageDirectory; }
            set { imageDirectory = value; }
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string imagePath = Path.Combine(ImageDirectory, (string)value);
            return new BitmapImage(new Uri(imagePath)); 
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("The method or operation is not implemented.");
        }
    }
}
