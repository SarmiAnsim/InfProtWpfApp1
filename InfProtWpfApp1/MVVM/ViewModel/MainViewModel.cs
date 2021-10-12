using InfProtWpfApp1.Core;
using InfProtWpfApp1.MVVM.Model;

namespace InfProtWpfApp1.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public UserModel User { get; set; }
        public RelayCommand UsersViewCommand { get; set; }
        public RelayCommand ChangePasswordViewCommand { get; set; }
        public RelayCommand ReferenceViewCommand { get; set; }
        public RelayCommand ChangeDataKeyViewCommand { get; set; }

        public UsersViewModel UsersVm { get; set; }
        public ChangePasswordViewModel ChangePasswordVm { get; set; }
        public ReferenceViewModel ReferenceVm { get; set; }
        public ChangeDataKeyViewModel ChangeDataKeyVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            User = App.CurrentUser;

            UsersVm = new UsersViewModel();
            ChangePasswordVm = new ChangePasswordViewModel();
            ReferenceVm = new ReferenceViewModel();
            ChangeDataKeyVm = new ChangeDataKeyViewModel();
            CurrentView = ReferenceVm;

            UsersViewCommand = new RelayCommand(o =>
            {
                CurrentView = UsersVm;
                App.WriteUsersData();
            });

            ChangePasswordViewCommand = new RelayCommand(o =>
            {
                CurrentView = ChangePasswordVm;
                App.WriteUsersData();
            });

            ReferenceViewCommand = new RelayCommand(o =>
            {
                CurrentView = ReferenceVm;
                App.WriteUsersData();
            });

            ChangeDataKeyViewCommand = new RelayCommand(o =>
            {
                CurrentView = ChangeDataKeyVm;
                App.WriteUsersData();
            });
        }

    }
}
