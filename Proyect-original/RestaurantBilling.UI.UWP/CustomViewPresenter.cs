using MvvmCross.WindowsUWP.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using Windows.Phone.UI.Input;
using Proyect.core.ViewModels;

namespace Proyect.UWP
{
    /// <summary>
    /// This custom presenter enables "back" navigation with a hardware button in Win Phone
    /// back actions in iOS, UWP, Droid.
    /// </summary>
    public class CustomViewPresenter : MvxWindowsViewPresenter, IMvxWindowsViewPresenter, IMvxViewPresenter
    {
        #region Field Members
        IMvxWindowsFrame _rootFrame;
        #endregion Field Members

        #region Ctors
        public CustomViewPresenter(IMvxWindowsFrame rootFrame) : base(rootFrame)
        {
            _rootFrame = rootFrame;
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }
        #endregion Ctors

        #region Methods - Private
        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            // Here we handle the hardware button back pressed
            // Grab the current view from the root frame
            // If the view isn't our main menu, we call the Close method to peform normal navigation
            // If we determine we are currently on the starting view of the app, let the device handle the event.
            var content = _rootFrame.Content as IMvxView;
            IMvxViewModel viewModel = content.DataContext as IMvxViewModel;
            if(viewModel as IngresarViewModel == null) {
                Close(viewModel);
                e.Handled = true;
            }
        }
        #endregion Methods - Public
    }
}
