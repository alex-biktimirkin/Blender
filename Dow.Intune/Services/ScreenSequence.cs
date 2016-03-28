using Dow.Intune.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dow.Intune.Services
{
    public static class ScreenSequence
    {
        public static Screen FirstScreen()
        {
            return Screen.FirstScreen;
        }

        public static Screen LastScreen()
        {
            return Enum.GetValues(typeof(Screen)).Cast<Screen>().Last();
        }

        public static Screen? NextScreenOrDefault(Screen screen)
        {
            if (screen == LastScreen())
                return null;

            return Enum.GetValues(typeof(Screen)).Cast<Screen>().FirstOrDefault(x => (int)x > (int)screen);
        }

        public static Screen? PrevScreenOrDefault(Screen screen)
        {
            if (screen == FirstScreen())
                return null;

            return Enum.GetValues(typeof(Screen)).Cast<Screen>().OrderByDescending(x => (int)x).FirstOrDefault(x => (int)x < (int)screen);
        }
    }
}
