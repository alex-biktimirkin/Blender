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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Practices.Unity;
using System.ComponentModel;

namespace Dow.Intune.Views
{
    /// <summary>
    /// Interaction logic for FirstScreen.xaml
    /// </summary>
    public partial class FirstScreen : UserControl
    {
        private FirstScreenViewModel ViewModel
        {
            get { return (FirstScreenViewModel)DataContext; }
            set { DataContext = value; }
        }

        public FirstScreen(FirstScreenViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }
    }
}
