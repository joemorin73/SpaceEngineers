using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Sandbox.ModAPI
{
    public interface IMyGWTimer
    {
        event ElapsedEventHandler Elapsed;

        bool AutoReset;
        bool Enabled;
        double Interval;

        void Close();
        void Start();
        void Stop();
    }
}
