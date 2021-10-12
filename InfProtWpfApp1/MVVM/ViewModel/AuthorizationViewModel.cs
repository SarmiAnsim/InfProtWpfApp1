using InfProtWpfApp1.Core;
using InfProtWpfApp1.MVVM.Model;
using InfProtWpfApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfProtWpfApp1.MVVM.ViewModel
{
    class AuthorizationViewModel : ObservableObject
    {
        public RelayCommand EnterCommand { get; set; }

        private string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

        private string _oldPass = "";
        public string OldPass
        {
            get { return _oldPass; }
            set { _oldPass = value; }
        }

        public AuthorizationViewModel()
        {
            EnterCommand = new RelayCommand(o =>
            {
                UserModel user = App.Users.FirstOrDefault(it => it.Login == _login);

                if (user != null &&
                App.GetMD5HashString(_login + _oldPass) == user.Password)
                {
                    if(!user.IsBlocked)
                    {
                        App.CurrentUser = App.Users[App.Users.IndexOf(user)];

                        var AW = App.Current.MainWindow;
                        if (App.VerificationPassword(_oldPass, _login, user.IsConfined))
                            App.Current.MainWindow = new MainWindow();
                        else
                        {
                            PassWindow PW = new PassWindow();
                            PW.Title.Text = "Пароль более недействителен";
                            PW.Result.TextWrapping = System.Windows.TextWrapping.Wrap;
                            PW.Result.Text = $"Ваш пароль устарел! Смените пароль для продолжения работы.";
                            PW.ShowDialog();

                            App.Current.MainWindow = new ChPassWindow();
                        }
                        AW.Close();
                        App.Current.MainWindow.Show();

                    } else
                    {
                        PassWindow PW = new PassWindow();
                        PW.Title.Text = "Аккаунт заблокирован";
                        PW.Result.TextWrapping = System.Windows.TextWrapping.Wrap;
                        PW.Result.Text = $"Ваш аккаунт был заблокирован, для его разблокировки обратитесь к администратору.";
                        PW.ShowDialog();
                    }
                }
                else
                {
                    PassWindow PW = new PassWindow();
                    PW.Title.Text = "Ошибка авторизации";
                    PW.Result.Text = $"Введен неверный логин или пароль";
                    PW.ShowDialog();
                }
            });
        }
    }
}
