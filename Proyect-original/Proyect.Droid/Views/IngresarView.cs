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
using Acr.UserDialogs;

namespace Proyect.Droid.Views
{
    [Activity(MainLauncher = false)]

    public class IngresarView : MvxActivity
    {
        public new core.ViewModels.IngresarViewModel ViewModel
        {
            get { return (core.ViewModels.IngresarViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Ingresar);
            UserDialogs.Init(this);

        }





    }
}