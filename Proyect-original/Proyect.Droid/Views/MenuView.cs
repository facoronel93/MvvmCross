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
    [Activity(Label = "Menu", MainLauncher = false, Icon = "@drawable/icon")]
    public class MenuView : MvxActivity
    {
        public new core.ViewModels.MenuViewModel ViewModel
        {
            get { return (core.ViewModels.MenuViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.Menu);

        }


    }
}