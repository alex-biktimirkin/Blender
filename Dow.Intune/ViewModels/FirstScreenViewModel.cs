using Dow.Intune.Models.Interfaces;
using Dow.Intune.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dow.Intune.ViewModels
{
    public class FirstScreenViewModel : NavigatingViewModelBase
    {
        public FirstScreenViewModel(INavigationModel navigationModel)
            : base(navigationModel)
        {
        }
    }
}
