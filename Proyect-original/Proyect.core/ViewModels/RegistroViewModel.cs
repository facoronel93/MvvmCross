using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Proyect.core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proyect.core.ViewModels
{
    public class RegistroViewModel : MvxViewModel
    {
        public override void Start()
        {

            base.Start();
       
        }

        public RegistroViewModel()
        {

        }

        Persona persona = new Persona();


        public string Usuario
        {
            get { return persona.Usuario; }
            set
            {
                persona.Usuario = value;
                RaisePropertyChanged(() => Usuario);
            }
        }

        public string Password
        {
            get { return persona.Password; }
            set
            {
                persona.Password = value;
                RaisePropertyChanged(() => Password);
            }
        }

        public string Nombre
        {
            get { return persona.Nombre; }
            set
            {
                persona.Nombre = value;
                RaisePropertyChanged(() => Nombre);
            }
        }


        public string Email
        {
            get { return persona.Email; }
            set
            {
                persona.Email = value;
                RaisePropertyChanged(() => Email);
            }
        }


        public ICommand GuardarPersona
        {
            get
            {
                return new MvxCommand(() =>
                {
                    Mvx.Resolve<Repository>().Insert(persona).Wait();
                    Close(this);

                });
            }
        }



    }
}
