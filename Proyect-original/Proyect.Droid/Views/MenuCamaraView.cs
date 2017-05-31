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
    [Activity(Label = "Menu Camara", MainLauncher = false, Icon = "@drawable/icon")]
    public class MenuCamaraView : MvxActivity
    {

        public new core.ViewModels.CamaraViewModel ViewModel
        {
            get { return (core.ViewModels.CamaraViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.MenuCamara);

        }
    }
        
}