using Dow.Intune.Enums;
using Dow.Intune.Models.Interfaces;
using Dow.Intune.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dow.Intune.Models
{
    public class NavigationModel : INavigationModel
    {
        private Screen currentScreen;

        public NavigationModel()
        {
            this.CurrentScreen = ScreenNavigation.FirstScreen();
        }

        public Screen CurrentScreen
        {
            get { return this.currentScreen; }
            set
            {
                if (this.currentScreen == value)
                    return;

                this.currentScreen = value;
                Events.Fire(ScreenChanged, this.CurrentScreen);
            }
        }

        public event Action<Screen> ScreenChanged;

        public void NavigateToNextScreen()
        {
            var nextScreen = this.CurrentScreen.NextScreenOrDefault();
            if (nextScreen.HasValue)
                this.CurrentScreen = nextScreen.Value;
        }

        public void NavigateToPrevScreen()
        {
            var prevScreen = this.CurrentScreen.PrevScreenOrDefault();
            if (prevScreen.HasValue)
                this.CurrentScreen = prevScreen.Value;
        }
    }
}
