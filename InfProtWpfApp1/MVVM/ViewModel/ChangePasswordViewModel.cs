using InfProtWpfApp1.Core;
using InfProtWpfApp1.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InfProtWpfApp1.MVVM.ViewModel
{
    class ChangePasswordViewModel : ObservableObject
    {
        public UserModel User { get; set; }
        public RelayCommand ChangeCommand { get; set; }

        public string ConfinedStatus { get; set; }

        private string _oldPass = "";
        public string OldPass
        {
            get { return _oldPass; }
            set { _oldPass = value; }
        }

        private string _newPass = "";
        public string NewPass
        {
            get { return _newPass; }
            set { _newPass = value; }
        }

        private string _repeatPass = "";
        public string RepeatPass
        {
            get { return _repeatPass; }
            set { _repeatPass = value; }
        }


        public ChangePasswordViewModel()
        {
            User = App.CurrentUser;
            ConfinedStatus = User.IsConfined ? "для Вас обязательно." : "для Вас не обязательно.";

            ChangeCommand = new RelayCommand(o =>
            {
                if(App.GetMD5HashString(User.Login + _oldPass) == User.Password)
                {
                    if(_newPass == _repeatPass)
                    {
                        if(App.VerificationPassword(_newPass, User.Login, User.IsConfined) && _newPass != _oldPass)
                        {
                            User.Password = App.GetMD5HashString(User.Login + _newPass);

                            App.WriteUsersData();

                            //_oldPass = "";
                            //_newPass = "";
                            //_repeatPass = "";

                            PassWindow PW = new PassWindow();
                            PW.Title.Text = "Успех!";
                            PW.Result.Text = $"{User.Login}, ваш пароль успешно изменен.";
                            PW.ShowDialog();

                            if(App.Current.MainWindow.GetType() == typeof(ChPassWindow))
                            {
                                var AW = App.Current.MainWindow;
                                App.Current.MainWindow = new MainWindow();
                                AW.Close();

                                App.Current.MainWindow.Show();
                            }
                        } else
                        {
                            //_newPass = "";
                            //_repeatPass = "";

                            PassWindow PW = new PassWindow();
                            PW.Title.Text = "Нужен другой пароль";
                            PW.Result.Text = $"Новый пароль не соответствует требованиям.\nПопробуйте придумать другой.";
                            PW.ShowDialog();
                        }
                    } else
                    {
                        //_newPass = "";
                        //_repeatPass = "";

                        PassWindow PW = new PassWindow();
                        PW.Title.Text = "Пароли не совпадают";
                        PW.Result.Text = $"Новый пароль нужно ввести дважды.";
                        PW.ShowDialog();
                    }
                } else
                {
                    //_oldPass = "";

                    PassWindow PW = new PassWindow();
                    PW.Title.Text = "Это точно Вы?)";
                    PW.Result.Text = $"Текущий пароль введен неверно!";
                    PW.ShowDialog();
                }
            });
        }
    }
}
