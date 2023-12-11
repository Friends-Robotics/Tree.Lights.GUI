using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Tree_Lights_GUI.ViewModel
{
    class SplashScreenViewModel : ViewModelBase
    {
        private bool _isViewVisible = true;
        public SplashScreenViewModel() {
            GotoMainMenuCommand = new ViewModelCommand((object obj) => IsViewVisible = false);

            SimulateLoading();
        }

        public ICommand GotoMainMenuCommand { get; }

        public bool IsViewVisible {
            get => _isViewVisible;
            set {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }
        private async void SimulateLoading(int delay = 1000) {
            await Task.Delay(delay);
            IsViewVisible = false;
        }
    }
}
