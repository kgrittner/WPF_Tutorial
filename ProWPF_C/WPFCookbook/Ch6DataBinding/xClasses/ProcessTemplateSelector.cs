using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Diagnostics;
using System.Windows;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses
{
    class ProcessTemplateSelector : DataTemplateSelector
    {
        public string SystemProcessTemplate { get; set; }
        public string UserProcessTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Process process = (Process)item;
            return ((FrameworkElement)container).FindResource(process.SessionId == 0 ? SystemProcessTemplate : UserProcessTemplate) as DataTemplate;
        }
    }
}
