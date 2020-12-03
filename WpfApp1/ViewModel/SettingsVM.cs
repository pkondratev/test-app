using System;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class SettingsVM : ViewModelBase
    {
        private SettingsModel Model { get; set; } = new SettingsModel();

        public DateTime RefreshTimeout
        {
            get => Model.RefreshTimeout;
            set
            {
                Model.RefreshTimeout = value;
                OnPropertyChanged();
            }
        }
    }
}