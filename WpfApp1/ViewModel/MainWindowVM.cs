using System.Windows.Input;
using WpfApp1.Command;

namespace WpfApp1.ViewModel
{
    public class MainWindowVM : ViewModelBase
    {
        private ViewModelBase _currentWindow;

        public ViewModelBase CurrentWindow
        {
            get => _currentWindow;
            set => base.SetValue(ref _currentWindow, value);
        }

        public MainWindowVM()
        {
            _currentWindow = new SettingsVM();

            OpenCrocCommand = new RelayCommand(o => CurrentWindow = new CrocVM());
            OpenSettingsCommand = new RelayCommand(o => CurrentWindow = new SettingsVM());
        }

        public ICommand OpenCrocCommand { get; set; }
        public ICommand OpenSettingsCommand { get; set; }
    }
}