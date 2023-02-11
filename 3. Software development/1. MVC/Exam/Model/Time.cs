namespace Exam.Model
{
    public class Time
    {
        private const int minutesIn1Hour = 60;
        private const int hoursIn1Day = 24;

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public Time(Time time)
        {
            Hours = time.Hours;
            Minutes = time.Minutes;
        }

        public int Hours { get; set; }

        public int Minutes { get; set; }

        public override string ToString()
        {
            if (Hours == 0)
            {
                return $"{Minutes} minutes";
            }

            return $"{Hours}:{Minutes:d2} hours";
        }

        public static Time operator-(Time time1, Time time2)
        {
            Time result = new Time(time1);

            if (time1.Minutes < time2.Minutes)
            {
                result.Minutes += minutesIn1Hour;
                result.Hours -= 1;
            }

            if (result.Hours <= 0)
            {
                result.Hours += hoursIn1Day;
            }

            result.Hours -= time2.Hours;
            result.Minutes -= time2.Minutes;

            return result;
        }

        public static bool operator ==(Time time1, Time time2)
            => time1.Hours == time2.Hours && time1.Minutes == time2.Minutes;

        public static bool operator !=(Time time1, Time time2)
            => !(time1 == time2);


        public static bool operator >(Time time1, Time time2)
        {
            if (time1.Hours != time2.Hours)
            {
                return time1.Hours > time2.Hours;
            }

            return time1.Minutes > time2.Minutes;
        }

        public static bool operator <(Time time1, Time time2)
            => !(time1 >= time2);

        public static bool operator >=(Time time1, Time time2)
            => time1 == time2 || time1 > time2;

        public static bool operator <=(Time time1, Time time2)
            => !(time1 > time2);
    }
}
