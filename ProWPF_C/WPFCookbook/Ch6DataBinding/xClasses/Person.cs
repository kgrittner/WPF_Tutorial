using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses
{
    class Person : ObservableObject
    {
        public string Name { get; set; }

        int _age;
        public int Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value, () => Age); }

        }
    }
}
