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
using MvvmCross.Droid.Views;
using MvvmCross.Core.ViewModels;

namespace Proyect.Droid.Views
{

    [Activity(Label = "Registro De Usuarios", MainLauncher = false, Icon = "@drawable/icon")]
    public class RegistroView : MvxActivity
    {
        public new core.ViewModels.RegistroViewModel ViewModel
        {
            get { return (core.ViewModels.RegistroViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Registro);

        }

    }
}