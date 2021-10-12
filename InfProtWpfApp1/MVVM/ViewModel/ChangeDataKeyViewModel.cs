using InfProtWpfApp1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfProtWpfApp1.MVVM.ViewModel
{
    class ChangeDataKeyViewModel : ObservableObject
    {
        public RelayCommand ChangeCommand { get; set; }

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


        public ChangeDataKeyViewModel()
        {
            ChangeCommand = new RelayCommand(o =>
            {
                if (App.GetMD5HashString(_oldPass) == App.DataKeyHash)
                {
                    if (_newPass == _repeatPass)
                    {
                        if (_newPass != _oldPass)
                        {
                            App.DataKeyHash = App.GetMD5HashString(_newPass);

                            App.WriteUsersData();

                            //_oldPass = "";
                            //_newPass = "";
                            //_repeatPass = "";

                            PassWindow PW = new PassWindow();
                            PW.Title.Text = "Успех!";
                            PW.Result.Text = "Парольная фраза успешно изменена.";
                            PW.ShowDialog();
                        }
                        else
                        {
                            //_newPass = "";
                            //_repeatPass = "";

                            PassWindow PW = new PassWindow();
                            PW.Title.Text = "Нужен другой пароль";
                            PW.Result.Text = $"Новая парольная фраза не должна совпадать с текущей.\nПопробуйте придумать другую.";
                            PW.ShowDialog();
                        }
                    }
                    else
                    {
                        //_newPass = "";
                        //_repeatPass = "";

                        PassWindow PW = new PassWindow();
                        PW.Title.Text = "Парольные фразы не совпадают";
                        PW.Result.Text = $"Новую парольную фразу нужно ввести дважды.";
                        PW.ShowDialog();
                    }
                }
                else
                {
                    //_oldPass = "";

                    PassWindow PW = new PassWindow();
                    PW.Title.Text = "Это точно Вы?)";
                    PW.Result.Text = $"Текущая парольная фраза введена неверно!";
                    PW.ShowDialog();
                }
            });
        }
    }
}
