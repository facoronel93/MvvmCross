using Acr.UserDialogs;
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
        private readonly Repository conn;
        private Persona persona;
        public RegistroViewModel(Repository repo)
        {
            persona = new Persona();
            conn = repo;
        }

       


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

        public ICommand verificarExistencia
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    await verificarUsuario(persona);

                });
            }
        }

        private async Task verificarUsuario(Persona datosPersona)
        {
            var resultado = conn.GetUser(datosPersona);

            if (resultado.Usuario == persona.Usuario)
            {
                await UserDialogs.Instance.AlertAsync("Nombre de Usuario NO Disponible", "Aviso");
            }
            else
            {
                await UserDialogs.Instance.AlertAsync("Nombre de Usuario Disponible", "Aviso");
              
            }
        }

        public ICommand GuardarPersona
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    var result = await UserDialogs.Instance.ConfirmAsync(new ConfirmConfig
                    {
                        Message = "Confimar",
                        OkText = "OK",
                        CancelText = "Cancel"
                    });
                    if (result)
                    {
                        Mvx.Resolve<Repository>().Insert(persona).Wait();
                    }
                    else
                    {
                        await UserDialogs.Instance.AlertAsync("Operacion Cancelada", "Aviso");
                    }

                    
                    Close(this);

                });
            }
        }



    }
}
