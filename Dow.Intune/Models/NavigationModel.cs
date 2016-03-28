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
            CurrentScreen = ScreenSequence.FirstScreen();
        }

        public Screen CurrentScreen
        {
            get { return this.currentScreen; }
            set
            {
                if (this.currentScreen == value)
                    return;

                this.currentScreen = value;
                Events.Fire(ScreenChanged, CurrentScreen);
            }
        }

        public event Action<Screen> ScreenChanged;

        public void NavigateToNextScreen()
        {
            var nextScreen = ScreenSequence.NextScreenOrDefault(CurrentScreen);
            if (nextScreen.HasValue)
                CurrentScreen = nextScreen.Value;
        }

        public void NavigateToPrevScreen()
        {
            var prevScreen = ScreenSequence.PrevScreenOrDefault(CurrentScreen);
            if (prevScreen.HasValue)
                CurrentScreen = prevScreen.Value;
        }
    }
}
