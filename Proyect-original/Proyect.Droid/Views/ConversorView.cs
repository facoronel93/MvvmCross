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
    [Activity(Label = "Conversor", MainLauncher = false, Icon = "@drawable/icon")]
    public class ConversorView : MvxActivity
    {
        public new core.ViewModels.ConversorViewModel ViewModel
        {
            get { return (core.ViewModels.ConversorViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Conversor);

        }





    }
}