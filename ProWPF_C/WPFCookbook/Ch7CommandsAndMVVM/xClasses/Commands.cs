using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace ProWPF_C.WPFCookbook.Ch7CommandsAndMVVM.xClasses
{
    static class Commands
    {
        static readonly RoutedUICommand _zoomNormalCommand = new RoutedUICommand("Zoom Normal", "Normal", typeof(Commands),
            new InputGestureCollection(new[] { new KeyGesture(Key.N, ModifierKeys.Alt) }));

        public static RoutedUICommand ZoomNormalCommand
        {
            get { return _zoomNormalCommand; }
        }
    }
}
