using InfProtWpfApp1.Core;
using InfProtWpfApp1.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InfProtWpfApp1.MVVM.ViewModel
{
    class UnlockDataViewModel : ObservableObject
    {
        public RelayCommand EnterCommand { get; set; }

        private string _oldPass = "";
        public string OldPass
        {
            get { return _oldPass; }
            set { _oldPass = value; }
        }

        public UnlockDataViewModel()
        {
            EnterCommand = new RelayCommand(o =>
            {
                bool firstStart = false;
                if (!Directory.Exists(@"Data"))
                    Directory.CreateDirectory(@"Data");
                if (!File.Exists(@"Data\UsersData.ipwa"))
                {
                    App.Users = new ObservableCollection<UserModel>() {
                        new UserModel() {
                            IsAdmin = true,
                            IsBlocked = false,
                            IsConfined = false,
                            IsHidden = Visibility.Visible,
                            Login = "ADMIN",
                            Password = App.GetMD5HashString("ADMIN" + "")
                        }
                    };
                    App.CurrentUser = App.Users[0];

                    firstStart = true;
                }
                if (firstStart ? App.WriteUsersData(_oldPass) : App.ReadUsersData(_oldPass))
                {
                    var AW = App.Current.MainWindow;
                    App.Current.MainWindow = new AuthorizationWindow();
                    AW.Close();
                    App.Current.MainWindow.Show();
                }
                else
                {
                    PassWindow PW = new PassWindow();
                    PW.Title.Text = "Парольная фраза введена неверно";
                    PW.Result.TextWrapping = System.Windows.TextWrapping.Wrap;
                    PW.Result.Text = $"Введенная парольная фраза неверна. Приложение завершает работу..";
                    PW.ShowDialog();

                    App.Current.MainWindow.Close();
                }
            });
        }
    }
}
