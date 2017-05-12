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
                
                return new MvxCommand(() => {
                    verificarUsuario();
                   // Mvx.Resolve<Repository>().GetUser(persona);
                  //  Mvx.Resolve<Repository>().Insert(persona).Wait();
                    Close(this);

                });
            }
        }
      
        
        private void verificarUsuario()
        {
           var resultado = conn.GetUser(persona);

            if (resultado == "validado")
            {          
                ShowViewModel<MenuViewModel>();
            }
            else
            {
                if (resultado == "incorrecto")
                {
                    // mostrar contraseña incorrecta
                }
                else
                {
                    //usuario inexistente
                }
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
