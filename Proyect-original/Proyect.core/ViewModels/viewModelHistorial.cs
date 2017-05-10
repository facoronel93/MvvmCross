using MvvmCross.Core.ViewModels;
using Proyect.core.Services.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Proyect.core.ViewModels
{
    public class viewModelHistorial : MvxViewModel
    {
        public viewModelHistorial()
        {
            ListadeClima = new ObservableCollection<DatosClima>();
        }

        private ObservableCollection<DatosClima> listadeClima;

        public ObservableCollection<DatosClima> ListadeClima
        {
            get { return listadeClima; }
            set
            {
                listadeClima = value;
                RaisePropertyChanged(() => ListadeClima);
            }
        }



        public void Init(string datos)
        {
            ListadeClima = JsonConvert.DeserializeObject<ObservableCollection<DatosClima>>(datos);

        }
   

     
    
        
       










       



    }





}

