using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Proyect.core.ViewModels
{
   public class MenuViewModel : MvxViewModel
    {

        public ICommand Clima
        {
            get
            {

                return new MvxCommand(() => {
                    ShowViewModel<viewModelClima>();
                });
            }
        }
       
        public ICommand Convertir
        {
            get
            {

                return new MvxCommand(() => {
                    ShowViewModel<ConversorViewModel>();
                });
            }
        }

        public ICommand Logout
        {
            get
            {

                return new MvxCommand(async () =>
                {

                    var result = await UserDialogs.Instance.ConfirmAsync(new ConfirmConfig
                    {
                        Message = "Confima salir",
                        OkText = "OK",
                        CancelText = "Cancel"
                    });
                    if (result)
                    {
                        ShowViewModel<IngresarViewModel>();
                    }
                });
            }
        }
    }
}
