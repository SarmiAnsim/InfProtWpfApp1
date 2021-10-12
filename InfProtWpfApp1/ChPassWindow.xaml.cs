using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InfProtWpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ChPassWindow.xaml
    /// </summary>
    public partial class ChPassWindow : Window
    {
        public ChPassWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.WriteUsersData();

            var AW = App.Current.MainWindow;
            App.Current.MainWindow = new AuthorizationWindow();
            AW.Close();

            App.Current.MainWindow.Show();

            App.CurrentUser = null;
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
