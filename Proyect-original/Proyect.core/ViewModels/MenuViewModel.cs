using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Plugins.PictureChooser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.IO;


namespace Proyect.core.ViewModels
{
   public class MenuViewModel : MvxViewModel
    {
        private readonly IMvxPictureChooserTask _pictureChooserTask;

        public MenuViewModel(IMvxPictureChooserTask pictureChooserTask)
        {
            _pictureChooserTask = pictureChooserTask;
        }

        private MvxCommand _takePictureCommand;

        public System.Windows.Input.ICommand TakePictureCommand
        {
            get
            {
                _takePictureCommand = _takePictureCommand ?? new MvxCommand(DoTakePicture);
                return _takePictureCommand;
            }
        }

        private void DoTakePicture()
        {
            _pictureChooserTask.TakePicture(400, 95, OnPicture, () => { });
        }

        private MvxCommand _choosePictureCommand;

        public System.Windows.Input.ICommand ChoosePictureCommand
        {
            get
            {
                _choosePictureCommand = _choosePictureCommand ?? new MvxCommand(DoChoosePicture);
                return _choosePictureCommand;
            }
        }

        private void DoChoosePicture()
        {
            _pictureChooserTask.ChoosePictureFromLibrary(400, 95, OnPicture, () => { });
        }

        private byte[] _bytes;

        public byte[] Bytes
        {
            get { return _bytes; }
            set { _bytes = value; RaisePropertyChanged(() => Bytes); }
        }

        private void OnPicture(Stream pictureStream)
        {
            var memoryStream = new MemoryStream();
            pictureStream.CopyTo(memoryStream);
            Bytes = memoryStream.ToArray();
        }

        public ICommand Clima
        {
            get
            {

                return new MvxCommand(() => {
                    ShowViewModel<viewModelClima>();
                });
            }
        }
       
        public ICommand Convertir
        {
            get
            {

                return new MvxCommand(() => {
                    ShowViewModel<ConversorViewModel>();
                });
            }
        }


  
        

        public ICommand Logout
        {
            get
            {

                return new MvxCommand(async () =>
                {
                   
                    var result = await UserDialogs.Instance.ConfirmAsync(new ConfirmConfig
                    {
                        Message = "Confima salir",
                        OkText = "OK",
                        CancelText = "Cancel"
                    });
                    if (result)
                    {
                        ShowViewModel<IngresarViewModel>();
                    }
                });
            }
        }
    }


}
