using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Platform;
using MvvmCross.WindowsUWP.Platform;
using MvvmCross.WindowsUWP.Views;
using Proyect.core.Services.Models;
using Windows.UI.Xaml.Controls;

namespace Proyect.UWP
{
    /// <summary>
    /// Every MvvmCross UI project needs a setup class.
    /// For UWP, inherit from MvxWindowsSetup
    /// 
    /// Initializes:
    /// - IoC system
    /// - MvvmCross data binding
    /// - App class and collection of ViewModels
    /// - UI project and collection of Views
    /// </summary>
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            var dbConn = FileAccessHelper.GetLocalFilePath("restaurant.db3");
            Mvx.RegisterSingleton(new Repository(dbConn));
            return new Proyect.core.App();
        }

        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {
            var customPresenter = new CustomViewPresenter(rootFrame);
            Mvx.RegisterSingleton<IMvxViewPresenter>(customPresenter);
            return customPresenter;
        }
    }
}
