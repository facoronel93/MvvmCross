using Android.App;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using Proyect.core.ViewModels;
using System;
using System.Net;
namespace Proyect.Droid
{
    //asd
    [Activity(Label = "Clima", MainLauncher = false, Icon = "@drawable/icon")]
    public class climaView : MvxActivity
    {
        public new core.ViewModels.viewModelClima ViewModel
        {
            get { return (core.ViewModels.viewModelClima)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.clima);
      
        }
   
        

     

    }
 }



