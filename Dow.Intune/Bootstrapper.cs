using Dow.Intune.Models;
using Dow.Intune.Models.Interfaces;
using Dow.Intune.Views;
using Dow.Intune.Views.ModuleDefinitions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dow.Intune
{
    internal class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(ScreenSaverModule));
            catalog.AddModule(typeof(FirstScreenModule));
            catalog.AddModule(typeof(SelectionScreen1Module));
            catalog.AddModule(typeof(SelectionScreen2Module));
            catalog.AddModule(typeof(SelectionScreen3Module));
            catalog.AddModule(typeof(SelectionScreen4Module));
            catalog.AddModule(typeof(ResultsScreen1Module));
            catalog.AddModule(typeof(ResultsScreen2Module));
            catalog.AddModule(typeof(ResultsScreen3Module));
            catalog.AddModule(typeof(ClosingScreenModule));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            RegisterModels();
        }

        private void RegisterModels()
        {
            Container.RegisterType<INavigationModel, NavigationModel>(new ContainerControlledLifetimeManager());
        }
    }
}
