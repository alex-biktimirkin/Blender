using Dow.Intune.Enums;
using Dow.Intune.Models.Interfaces;
using Dow.Intune.ViewModels;
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

namespace Dow.Intune.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public MainWindow(INavigationModel navigationModel)
        {
            InitializeComponent();

            viewModel = new MainViewModel(navigationModel);
            this.DataContext = viewModel;
        }
    }
}
