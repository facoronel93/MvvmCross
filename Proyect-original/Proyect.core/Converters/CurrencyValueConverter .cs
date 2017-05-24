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
            var tipoMoneda = value.Substring(0, Math.Min(value.Length, 3));
            var valor = value.Substring(3);
            string simbolo = string.Empty;

            switch (tipoMoneda)
            {
                case "ARS":
                    simbolo= "$";
                    break;
                case "USD":
                    simbolo ="US$";
                    break;
                case "EUR":
                    simbolo = "€";
                    break;    
            }
            return $"{simbolo} {valor}";
        }

    }


}
