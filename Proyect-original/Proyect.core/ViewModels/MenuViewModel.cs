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
    }
}
