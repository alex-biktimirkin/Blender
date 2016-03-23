using Dow.Intune.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dow.Intune.Models.Interfaces
{
    public interface INavigationModel
    {
        Screen CurrentScreen { get; set; }

        event Action<Screen> ScreenChanged;

        void NavigateToNextScreen();
        void NavigateToPrevScreen();
    }
}
