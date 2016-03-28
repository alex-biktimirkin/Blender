using Dow.Intune.Enums;
using Dow.Intune.Models;
using Dow.Intune.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dow.Intune.ViewModels.Base
{
    public abstract class NavigationViewModelBase : ViewModelBase
    {
        private readonly INavigationModel navigationModel;

        public DelegateCommand GoNext { get; private set; }
        public DelegateCommand GoBack { get; private set; }

        public NavigationViewModelBase()
        {
        }

        public NavigationViewModelBase(INavigationModel navigationModel)
        {
            this.navigationModel = navigationModel;

            this.GoNext = new DelegateCommand(DoGoNext, CanGoNext);
            this.GoBack = new DelegateCommand(DoGoBack, CanGoBack);
        }

        protected virtual void DoGoNext()
        {
            this.navigationModel.NavigateToNextScreen();
        }

        protected virtual void DoGoBack()
        {
            this.navigationModel.NavigateToPrevScreen();
        }

        protected virtual bool CanGoNext() { return true; }
        protected virtual bool CanGoBack() { return true; }
    }
}
