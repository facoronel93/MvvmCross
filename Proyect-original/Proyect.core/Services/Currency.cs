using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.core.Services
{
   public class Currency
    {
        public Currency(string dato)
        {
            this.Valor = dato;
        }

        public string Valor { get; private set; }

        public override int GetHashCode()
        {
            return Valor?.GetHashCode() ?? -1;
        }

        public override bool Equals(object obj)
        {
            return Valor == (obj as Currency)?.Valor;
        }

        public override string ToString()
        {
            return Valor;
        }

        /*private string valor;
        public string Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }*/



    }
}
