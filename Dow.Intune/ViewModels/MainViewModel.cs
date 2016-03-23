using Dow.Intune.Enums;
using Dow.Intune.Models.Interfaces;
using Dow.Intune.Services;
using Dow.Intune.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dow.Intune.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private INavigationModel navigationModel;

        public MainViewModel(INavigationModel navigationModel)
        {
            this.navigationModel = navigationModel;
        }

        public Screen CurrentScreen
        {
            get { return this.navigationModel.CurrentScreen; }
        }
    }
}
