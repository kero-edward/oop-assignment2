using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment2
{
    internal class HiringDate
    {
        private int day;
        private int month;
        private int year;

        public HiringDate(int _day, int _month, int _year)
        {
            this.Day = _day;
            this.Month = _month;
            this.Year = _year;
        }

        public int Day
        {
            get { return day; }
            set
            {
                if (value < 1 || value > 31)
                    throw new ArgumentException("Day must be between 1 and 31.");
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Month must be between 1 and 12.");
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("Year must be between 1900 and the current year.");
                year = value;
            }
        }

        public override string ToString()
        {
            return $"{Day:00}/{Month:00}/{Year}";
        }
    }
}
