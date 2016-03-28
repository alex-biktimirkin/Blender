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
using Microsoft.Practices.Unity;
using System.ComponentModel;

namespace Dow.Intune.Views
{
    /// <summary>
    /// Interaction logic for SelectionScreen1.xaml
    /// </summary>
    public partial class SelectionScreen1 : UserControl
    {
        private SelectionScreen1ViewModel ViewModel
        {
            get { return (SelectionScreen1ViewModel)DataContext; }
            set { DataContext = value; }
        }
        
        public SelectionScreen1()
        {
            InitializeComponent();

            if (DesignerProperties.GetIsInDesignMode(this))
                ViewModel = new SelectionScreen1ViewModel();
            else
                ViewModel = App.Container.Resolve<SelectionScreen1ViewModel>();
        }
    }
}
