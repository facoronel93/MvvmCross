using Microsoft.Phone.Controls;
using MvvmCross.Core.ViewModels;
using MvvmCross.WindowsPhone.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect.Phone
{
    class Setup : MvxPhoneSetup
    {
        public Setup(PhoneApplicationFrame rootFrame)
            : base(rootFrame)
        {
        }
        protected override IMvxApplication CreateApp()
        {
            //we register this here in order to use it in the App.cs initialization
            return new core.App();
        }
    }
}
