﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses
{
    class ThreadsToGroupNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int count = (int)value;
            string text = string.Format("{0}-{1}", count == 0 ? 1 : count * 10, count * 10 + 9);
            return text;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
