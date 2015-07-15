using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookbookMVVM
{
    public abstract class ViewModelBase : ObservableCollection
    {
    }//End Class 1

    public abstract class ViewModelBase<TModel> : ViewModelBase
    {
        TModel _model;

        public TModel Model {
            get { return _model; }
            set { SetProperty(ref _model, value, () => Model); }
        }

    }// End Class 2
}// End Namespace
