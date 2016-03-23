using Dow.Intune.Models;
using Dow.Intune.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Dow.Intune
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            var navigationModel = new NavigationModel();
            var mainWindow = new MainWindow(navigationModel);
            Application.Current.MainWindow = mainWindow;
        }
    }
}
