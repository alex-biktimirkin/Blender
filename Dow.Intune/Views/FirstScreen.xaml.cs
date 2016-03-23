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

namespace Dow.Intune.Views
{
    /// <summary>
    /// Interaction logic for FirstScreen.xaml
    /// </summary>
    public partial class FirstScreen : UserControl
    {
        private FirstScreenViewModel viewModel;

        public FirstScreen(INavigationModel navigationModel)
        {
            InitializeComponent();

            this.viewModel = new FirstScreenViewModel(navigationModel);
            this.DataContext = viewModel;
        }
    }
}
