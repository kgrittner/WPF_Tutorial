using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses
{
    class Person3
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0} is {1} years old", Name, Age);
        }
    }
}
