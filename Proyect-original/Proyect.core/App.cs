
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
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

            RegisterAppStart(new CustomStart());

            }
            
            
            public class CustomStart : MvxNavigatingObject, IMvxAppStart
             {
                 public void Start(object hint = null)
                 {
                this.ShowViewModel<ConversorViewModel>();
                 }
             }

    }   
 }
