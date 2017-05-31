using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using Proyect.core.Services.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proyect.core.ViewModels
{
    public class IngresarViewModel : MvxViewModel
    {
      

        public override void Start()
        {

            base.Start();

        }
        private readonly Repository conn;
        public IngresarViewModel(Repository repo)
        {
            conn = repo;
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


        Persona respuestaDb = new Persona();
        public ICommand Ingresar
        {
            get
            {
                
                return new MvxCommand(async () =>
                {
                    await verificarUsuario();
                    Close(this);

                });
            }
        }

        private async Task verificarDatos(Persona persona)
        {
            if (persona.Usuario == Usuario)
            {
                if (persona.Password == Password)
                {
                     var result = await UserDialogs.Instance.ConfirmAsync(new ConfirmConfig
                     {
                         Message = "Confimar Login",
                         OkText = "OK",
                         CancelText = "Cancel"
                     });

                  
                    if (result)
                    {
                        ShowViewModel<MenuViewModel>();
                    }
                    else
                    {
                        ShowViewModel<IngresarViewModel>();
                    }
                    
                }
                else
                {
                  await  UserDialogs.Instance.AlertAsync("constraseña incorrecta", "Aviso");
                    // ShowViewModel<IngresarViewModel>();
                }
            }
            else
            {              
                await UserDialogs.Instance.AlertAsync("usuario incorrecto", "Aviso");
              //  ShowViewModel<IngresarViewModel>();
            }

        }
        private async Task verificarUsuario()
        {
            try
            {
                var resultado = conn.GetUser(persona);

                await verificarDatos(resultado);
            }
            catch(Exception )
            {
                await UserDialogs.Instance.AlertAsync("usuario incorrecto", "Aviso");
                ShowViewModel<IngresarViewModel>();
            }

        }


        public ICommand Registrar
        {
            get
            {

                return new MvxCommand(() => {
                    ShowViewModel<RegistroViewModel>();
                });
            }
        }
    }
}
