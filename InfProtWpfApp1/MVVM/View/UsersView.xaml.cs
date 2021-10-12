using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Xml.Serialization;
using System;
using System.Linq;
using System.Xml;
using System.IO;
using System.ComponentModel;
using System.Windows.Data;
using System.Collections.Generic;
using InfProtWpfApp1.MVVM.Model;
using InfProtWpfApp1.MVVM.ViewModel;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace InfProtWpfApp1.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для UsersView.xaml
    /// </summary>
    public partial class UsersView : UserControl
    {
        public UsersView()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Debug.WriteLine($"SearchText: {UsersViewModel.SearchText}");

            if(UsersViewModel.SearchText != "")
            {
                for (int i = 0; i < App.Users.Count; ++i)
                {
                    string login = App.Users[i].Login.ToLower();
                    string searchtext = UsersViewModel.SearchText.ToLower();
                    bool flag = login.Contains(searchtext);
                    var result = flag ? Visibility.Visible : Visibility.Collapsed;

                    App.Users[i].IsHidden = result;
                }
            }
            else
            {
                for (int i = 0; i < App.Users.Count; ++i)
                {
                    App.Users[i].IsHidden = Visibility.Visible;
                }
            }
            UsersList.Items.Refresh();
        }
    }
}
