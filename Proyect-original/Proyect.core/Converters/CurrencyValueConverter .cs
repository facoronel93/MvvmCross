using MvvmCross.Platform.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.core.Converters
{
    public class CurrencyConverter : MvxValueConverter<string, string>
    {
        protected override string Convert(string value, Type targetType, object parameter, CultureInfo culture)
        {
            value = value ?? " ";
          //  return value.Length;

            if (value == "ARS")
            {
                return value+"$";
            }
            else
            {
                if (value == "USD")
                {
                    return value + "US$";
                }
                else
                {
                    if (value == "EUR")
                    {
                        return value + "€";
                    }
                }
                return string.Empty;
            }
        }
    }


}
