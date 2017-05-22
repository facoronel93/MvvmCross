using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using Proyect.core;
using MvvmCross.Platform;
using Proyect.core.Services.Models;
using MvvmCross.Binding.Bindings.Target.Construction;

namespace Proyect.Droid
{

    public class Setup : MvxAndroidSetup
    {
        

        public Setup(Context applicationContext) : base(applicationContext)
        {
           
        }
   
        protected override IMvxApplication CreateApp()
        {
            var dbConn = FileAccessHelper.GetLocalFilePath("Personas.db3");
            Mvx.RegisterSingleton(new Repository(dbConn));
            
            return new Proyect.core.App();
        }

    }
}