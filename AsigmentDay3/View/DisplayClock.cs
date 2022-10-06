using AsigmentDay3.Events;
using System;
namespace AsigmentDay3.View
{
    public class DisplayClock
    {
        public void Subcribe(Clock clock)
        {
            clock.clockTick += new Clock.clockTickHandler(ShowClock);
        }
        public void ShowClock(object clock, ClockEventAgrs clockEventAgrs)
        {
            Console.WriteLine(clockEventAgrs.hour + " : " + clockEventAgrs.minute + " : " + clockEventAgrs.second);
        }
    }
}