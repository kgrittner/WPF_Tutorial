using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses
{
    class SortField
    {
        public string DisplayName { get; set; }
        public string PropertyName { get; set; }
    }

    class SortFieldList : List<SortField>
    {
    }
}
