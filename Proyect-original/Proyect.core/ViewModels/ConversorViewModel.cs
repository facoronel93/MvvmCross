using MvvmCross.Core.ViewModels;
using Newtonsoft.Json;
using Proyect.core.Services;
using Proyect.core.Services.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proyect.core.ViewModels
{
   public class ConversorViewModel : MvxViewModel
    {
        
       private ObservableCollection<Currency> opciones;

        public ObservableCollection<Currency> Opciones
        {
            get { return opciones; }
            set
            {
                opciones = value;
                this.RaisePropertyChanged(() => this.Opciones);
            }
        }
        
        public ConversorViewModel()
        {
            Opciones = new ObservableCollection<Currency>()
            {
                 new Currency("USD"),
                 new Currency("EUR"),
                 new Currency("ARS"),
            };
        }

        public override void Start()
        {
            base.Start();
          
    }
     

        private string monedaOrigen;
        public string MonedaOrigen
        {
            get { return monedaOrigen; }
            set
            {
                monedaOrigen = value;
                this.RaisePropertyChanged(() => this.MonedaOrigen);
            }
        }

        private string monedaDestino;
        public string MonedaDestino
        {
            get { return monedaDestino; }
            set
            {
                monedaDestino = value;
                this.RaisePropertyChanged(() => this.MonedaDestino);
            }
        }

        private string valor;
        public string Valor
        {
            get { return valor; }
            set
            {
                valor = value;
                this.RaisePropertyChanged(() => this.Valor);
            }
        }

        private string nuevoValor;
        public string NuevoValor
        {
            get { return nuevoValor; }
            set
            {
                nuevoValor = value;
                this.RaisePropertyChanged(() => this.NuevoValor);
            }
        }
        private ICommand convertir;
        public ICommand Convertir
        {
            get { return this.convertir = this.convertir ?? new MvxAsyncCommand(this.getValue); }
        }

        private async Task getValue()
        {
        
            var url = new Uri($"http://devel.farebookings.com/api/curconversor/{MonedaOrigen}/{MonedaDestino}/{Valor}/json"); 
            var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync(url);
            httpClient.Dispose();
            RespuestaConversor json = JsonConvert.DeserializeObject<RespuestaConversor>(result);       
            if(json.usd != null)
            {
                this.NuevoValor =monedaDestino+" "+ json.usd;
            }
            else
            {
                if (json.eur != null)
                {
                    this.NuevoValor = monedaDestino + " " + json.eur;
                }
                else
                {
                    if (json.ars != null)
                    {
                        this.NuevoValor = monedaDestino + " " + json.ars;
                    }
                }

            }       
        }
        
     

        
     

}
}

