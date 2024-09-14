using StepStyle.WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StepStyle.WPF
{
    public class App : System.Windows.Application
    {
        readonly LoginView loginView;

        public App(LoginView loginView)
        {
            this.loginView = loginView;
            ShutdownMode = ShutdownMode.OnLastWindowClose;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            loginView.Show(); 
            base.OnStartup(e);
        }
    }
}
