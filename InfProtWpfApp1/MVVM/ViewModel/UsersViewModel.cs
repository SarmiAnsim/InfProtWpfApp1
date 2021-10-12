
using InfProtWpfApp1.Core;
using InfProtWpfApp1.MVVM.Model;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace InfProtWpfApp1.MVVM.ViewModel
{
    class UsersViewModel : ObservableObject
    {
        public static ObservableCollection<UserModel> Users { get; set; }

        public RelayCommand AddCommand { get; set; }

        private string _login;
        public string Login
        {
            get { return _login; }
            set { 
                _login = value;
                OnPropertyChanged();
            }
        }

        private static string _searchtext;
        public static string SearchText
        {
            get { return _searchtext; }
            set { 
                _searchtext = value;
            }
        }

        public UsersViewModel()
        {
            Users = App.Users;

            AddCommand = new RelayCommand(o =>
            {
                if(_login != null && _login.Length > 3 && !Users.Any(it => it.Login == _login))
                {
                    string pass = App.GenPassword();
                    App.Users.Add(new UserModel()
                    {
                        Login = _login,
                        Password = App.GetMD5HashString(_login + pass),
                        IsAdmin = false,
                        IsBlocked = false,
                        IsConfined = false
                    });
                    App.WriteUsersData();

                    _login = "";

                    PassWindow PW = new PassWindow();
                    PW.Result.Text = $"Временный пароль пользователя {_login}: \n{pass}";
                    PW.ShowDialog();
                } else
                {
                    PassWindow PW = new PassWindow();
                    PW.Title.Text = "Ошибка ввода логина";
                    if(_login != null && _login.Length > 3)
                        PW.Result.Text = $"Пользователь с таким логином уже существует.\nИспользуйте другой логин.";
                    else
                        PW.Result.Text = $"Логин должен содержать более трех символов.\nИспользуйте другой логин.";
                    PW.ShowDialog();
                }
            });

            //WriteUsersData();
            //ReadUsersData();

            /*Task.Run(() =>
            {
                while (true)
                {
                    Debug.WriteLine($"Login: {Users[0].Login}, IsBlock: {Users[0].IsBlocked}, IsConf: {Users[0].IsConfined}");
                    Thread.Sleep(500);
                }
            });*/
        }
    }
}
