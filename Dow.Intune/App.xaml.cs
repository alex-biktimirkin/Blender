using Dow.Intune.Models;
using Dow.Intune.Models.Interfaces;
using Dow.Intune.ViewModels;
using Dow.Intune.Views;
using Microsoft.Practices.Unity;
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
        public static IUnityContainer Container
        {
            get;
            private set;
        }

        static App()
        {
            Container = new UnityContainer();
        }
        
        public App()
        {
            this.Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            InitializeContainer();

            Application.Current.MainWindow = Container.Resolve<MainWindow>();
            Application.Current.MainWindow.Show();
        }

        private void InitializeContainer()
        {
            RegisterModels();
            RegisterViewModels();
            RegisterViews();
        }

        private void RegisterModels()
        {
            Container.RegisterType<INavigationModel, NavigationModel>(new ContainerControlledLifetimeManager());
        }

        private void RegisterViewModels()
        {
            Container.RegisterType<MainWindowViewModel>();
            Container.RegisterType<ScreenSaverViewModel>();
            Container.RegisterType<FirstScreenViewModel>();
            Container.RegisterType<SelectionScreen1ViewModel>();
            Container.RegisterType<SelectionScreen2ViewModel>();
            Container.RegisterType<SelectionScreen3ViewModel>();
            Container.RegisterType<SelectionScreen4ViewModel>();
            Container.RegisterType<ResultsScreen1ViewModel>();
            Container.RegisterType<ResultsScreen2ViewModel>();
            Container.RegisterType<ResultsScreen3ViewModel>();
            Container.RegisterType<ClosingScreenViewModel>();
        }

        private void RegisterViews()
        {
            Container.RegisterType<MainWindow>();
            Container.RegisterType<ScreenSaver>();
            Container.RegisterType<FirstScreen>();
            Container.RegisterType<SelectionScreen1>();
            Container.RegisterType<SelectionScreen2>();
            Container.RegisterType<SelectionScreen3>();
            Container.RegisterType<SelectionScreen4>();
            Container.RegisterType<ResultsScreen1>();
            Container.RegisterType<ResultsScreen2>();
            Container.RegisterType<ResultsScreen3>();
            Container.RegisterType<ClosingScreen>();
        }
    }
}
