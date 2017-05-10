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

namespace Proyect.Droid.Views
{
    [Activity(Label = "Clima", MainLauncher = true, Icon = "@drawable/icon")]
    public class historialView : MvxActivity
    {
        public new core.ViewModels.viewModelHistorial ViewModel
        {
            get { return (core.ViewModels.viewModelHistorial)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.Lista);

        }


    }
}

