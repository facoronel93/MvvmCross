
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
        public override void Initialize()
        {     
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);
        }
        public App()
            {

            RegisterAppStart(new CustomStart());

            }
            
            //
            public class CustomStart : MvxNavigatingObject, IMvxAppStart
             {
                 public void Start(object hint = null)
                 {
                this.ShowViewModel<IngresarViewModel>();
                 }
             }

    }   
 }
