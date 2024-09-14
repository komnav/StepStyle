using Application.Services;
using StepStyle.WPF.Helpers;
using StepStyle.WPF.Views;
using System.Windows;
using System.Windows.Input;

namespace StepStyle.WPF.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IUserService _userService;

        public LoginViewModel(IUserService userService)
        {
            _userService = userService;
        }

        public string UserName { get; set; }

        public string Password { get; set; }

        public void Login()
        {
            var userExists = _userService.Login(UserName, Password);
            if (userExists)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Не правильный логин или пароль");
            }
        }

        ICommand loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (loginCommand == null)
                {
                    loginCommand = new RelayCommand((obj) => Login());
                }

                return loginCommand;
            }
        }
    }
}
