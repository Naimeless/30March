using Service;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Autoresation.List
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var login = LoginInput.Text.Trim();

            var password = PasswordInput.Text.Trim();

            var loginStatus = LoginService.Login(login, password);

            if (loginStatus == "Вход выполнен")
            {
                var mainWindow = MainWindow.GetWindow(this) as MainWindow;
                mainWindow.MainFrame.Navigate(new ClientList());
                
            }
            else
            {
                MessageBox.Show(loginStatus);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
