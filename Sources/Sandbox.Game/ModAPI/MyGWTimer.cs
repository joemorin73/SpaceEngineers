using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.ModAPI
{
    public class MyGWTimer : System.Timers.Timer, IMyGWTimer
    {
        System.Timers.Timer m_Timer = null;

        internal MyGWTimer()
        {
            
        }

        internal MyGWTimer(double interval)
        {
            m_Timer = new System.Timers.Timer(interval);
        }

        event System.Timers.ElapsedEventHandler IMyGWTimer.Elapsed
        {
            add { m_Timer.Elapsed += value; }
            remove { m_Timer.Elapsed -= value; }
        }

        void IMyGWTimer.Close()
        {
            m_Timer.Close();
        }

        void IMyGWTimer.Start()
        {
            m_Timer.Start();
        }

        void IMyGWTimer.Stop()
        {
            m_Timer.Stop();
        }
    }
}
