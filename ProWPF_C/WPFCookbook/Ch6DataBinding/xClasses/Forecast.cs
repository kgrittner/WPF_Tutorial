using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProWPF_C.WPFCookbook.Ch6DataBinding.xClasses
{
    enum GeneralForecast
    {
        Sunny,
        Rainy,
        Snowy,
        Cloudy,
        Dry
    }

    class Forecast
    {
        public GeneralForecast GeneralForecast { get; set; }
        public double TemperatureHigh { get; set; }
        public double TemperatureLow { get; set; }
        public double Percipitation { get; set; }
    }
}
