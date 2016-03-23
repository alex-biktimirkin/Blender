using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dow.Intune.Services
{
    public static class Events
    {
        public static void Fire(Action @event, bool onSameThread = true)
        {
            var tmp = @event;
            if (tmp != null)
            {
                if (onSameThread)
                    tmp();
                else
                    Task.Run(() => tmp());
            }
        }

        public static void Fire<T>(Action<T> @event, T value, bool onSameThread = true)
        {
            var tmp = @event;
            if (tmp != null)
            {
                if (onSameThread)
                    tmp(value);
                else
                    Task.Run(() => tmp(value));
            }
        }

        public static void Fire<T1, T2>(Action<T1, T2> @event, T1 value1, T2 value2, bool onSameThread = true)
        {
            var tmp = @event;
            if (tmp != null)
            {
                if (onSameThread)
                    tmp(value1, value2);
                else
                    Task.Run(() => tmp(value1, value2));
            }
        }

        public static void Fire<T1, T2, T3>(Action<T1, T2, T3> @event, T1 value1, T2 value2, T3 value3, bool onSameThread = true)
        {
            var tmp = @event;
            if (tmp != null)
            {
                if (onSameThread)
                    tmp(value1, value2, value3);
                else
                    Task.Run(() => tmp(value1, value2, value3));
            }
        }

        public static void Fire<T1, T2, T3, T4>(Action<T1, T2, T3, T4> @event, T1 value1, T2 value2, T3 value3, T4 value4, bool onSameThread = true)
        {
            var tmp = @event;
            if (tmp != null)
            {
                if (onSameThread)
                    tmp(value1, value2, value3, value4);
                else
                    Task.Run(() => tmp(value1, value2, value3, value4));
            }
        }
    }
}
