using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1_C_
{
    internal class ClockTime
    {
        private int hours;
        private int minutes;
        private int seconds;

        public int Hours
        {
            get => hours;
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Часы должны находиться в промежутке между 0 и 23 часами");
                }
                hours = value;
            }
        }

        public int Minutes
        {
            get => minutes;
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Минуты должны находиться в промежутке между 0 и 59 минутами");
                }
                minutes = value;
            }
        }

        public int Seconds
        {
            get => seconds;
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Секунды должны находиться в промежутке между 0 и 59 секундами");
                }
                seconds = value;
            }
        }

        public ClockTime(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public ClockTime(int hours) : this(hours, 0, 0) { }

        public ClockTime()
        {
            DateTime now = DateTime.Now;
            hours = now.Hour;
            minutes = now.Minute;
            seconds = now.Second;
        }

        public int ToSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

        public int ClockTimeOffSet(ClockTime other)
        {
            return this.ToSeconds() - other.ToSeconds();
        }

        public void Tick()
        {
            seconds++;
            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
                if(minutes == 60)
                {
                    minutes = 0;
                    hours++;
                    if(hours == 24)
                    {
                        hours = 0;
                    }
                }
            }
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }
    }
}
