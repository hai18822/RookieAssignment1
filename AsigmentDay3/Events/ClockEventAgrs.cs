namespace AsigmentDay3.Events
{
    public class ClockEventAgrs : EventArgs
    {
        public readonly int hour;
        public readonly int minute;
        public readonly int second;

        public ClockEventAgrs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
    }
}