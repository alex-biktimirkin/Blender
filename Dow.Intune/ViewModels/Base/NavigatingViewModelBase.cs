using Dow.Intune.Models;
using Dow.Intune.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dow.Intune.ViewModels.Base
{
    public abstract class NavigatingViewModelBase : ViewModelBase
    {
        private INavigationModel navigationModel;

        public DelegateCommand GoNext { get; private set; }
        public DelegateCommand GoBack { get; private set; }

        public NavigatingViewModelBase(INavigationModel navigationModel)
        {
            this.navigationModel = navigationModel;

            this.GoNext = new DelegateCommand(
                () =>
                {
                    BeforeGoNext();
                    this.navigationModel.NavigateToNextScreen();
                },
                CanGoNext);

            this.GoBack = new DelegateCommand(
                () =>
                {
                    BeforeGoBack();
                    this.navigationModel.NavigateToPrevScreen();
                },
                CanGoBack);
        }

        protected virtual void BeforeGoNext() { }
        protected virtual void BeforeGoBack() { }

        protected virtual bool CanGoNext() { return true; }
        protected virtual bool CanGoBack() { return true; }
    }
}
