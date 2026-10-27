using CacheBooster.helps;
using System.Windows.Input;

namespace CacheBooster.viewmodel
{
    // ViewModel dành riêng cho HomePage
    public class HomePageViewModel : BaseViewModel
    {
    }

    // ViewModel trung tâm điều hướng ứng dụng
    public class HomeControl : BaseViewModel
    {
        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        private object _subCurrentView;
        public object SubCurrentView
        {
            get => _subCurrentView;
            set
            {
                _subCurrentView = value;
                OnPropertyChanged();
            }
        }

        // Các Command cho Sidebar của HomePage
        public ICommand StartCommand { get; }
        public ICommand PauseCommand { get; }
        public ICommand StopCommand { get; }
        public ICommand SelectDiskCommand { get; }

        public HomeControl()
        {
            // Mặc định load HomePageViewModel khi khởi động
            CurrentView = new HomePageViewModel();

            // Khởi tạo các Command
            StartCommand = new RelayCommand(_ => ExecuteStart());
            PauseCommand = new RelayCommand(_ => ExecutePause());
            StopCommand = new RelayCommand(_ => ExecuteStop());
            SelectDiskCommand = new RelayCommand(_ => ExecuteSelectDisk());
        }

        private void ExecuteStart()
        {
            // Thêm logic khi bấm Start
        }

        private void ExecutePause()
        {
            // Thêm logic khi bấm Pause
        }

        private void ExecuteStop()
        {
            // Thêm logic khi bấm Stop
        }

        private void ExecuteSelectDisk()
        {
            // Thêm logic chọn ổ đĩa
        }
    }
}