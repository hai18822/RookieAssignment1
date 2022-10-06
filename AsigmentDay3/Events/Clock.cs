namespace AsigmentDay3.Events
{
    public class Clock
    {
        private readonly int _second;
        public delegate void clockTickHandler(object clock, ClockEventAgrs clockEventAgrs);
        public event clockTickHandler clockTick;

        protected void OnTick(object clock, ClockEventAgrs clockEventAgrs)
        {
            if (clockTick != null)
            {
                clockTick(clock, clockEventAgrs);
            }
        }
        
        public void Run()
        {
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(1000);
                var time = DateTime.Now;

                if (time.Second != _second)
                {
                    var clockEventAgrs = new ClockEventAgrs(time.Hour, time.Minute, time.Second);
                    OnTick(this,clockEventAgrs);
                }
            }
        }
    }
}