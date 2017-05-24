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
            var cadena = new StringBuilder(value);
            
  
            if (cadena[0]=='A' && cadena[1] == 'R' && cadena[2] == 'S' )
            {
                cadena[0] = cadena[1] = ' ';
                cadena[2] = '$';
                return cadena.ToString();
            }
            else
            {
                if (cadena[0] == 'U' && cadena[1] == 'S' && cadena[2] == 'D')
                {
                    cadena[0] = 'U';
                    cadena[1] = 'S';
                    cadena[2] = '$';
                    return cadena.ToString();
                }
                else
                {
                    if (cadena[0] == 'E' && cadena[1] == 'U' && cadena[2] == 'R')
                    {
                        cadena[0] = cadena[1] = ' ';
                        cadena[2] = '€';
                        return cadena.ToString();
                    }
                }
                return string.Empty;
            }
        }
    }


}
