
using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using Proyect.core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.core
{
    public class App : MvxApplication
    {

        public App()
            {
            Mvx.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);
            //  RegisterAppStart(new CustomStart());
            var appStart = new CustomAppStart();
            Mvx.RegisterSingleton<IMvxAppStart>(appStart);

        }
            
            //
           /* public class CustomStart : MvxNavigatingObject, IMvxAppStart
             {
                 public void Start(object hint = null)
                 {
                this.ShowViewModel<IngresarViewModel>();
                 }
             }*/

    }   
 }
