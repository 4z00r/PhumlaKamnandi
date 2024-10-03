using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    /*
      * Class to document the dates of a booking
      */
    public class Period
    {

        private DateTime checkIn, checkOut;
        private List<DateTime> dates;
        public enum Season
        {
            peakSeason,
            midSeason,
            offSeason
        }
        private Season season;

        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }
        public List<DateTime> Dates
        {
            get { return dates; }
            set { dates = value; }
        }
        public Period(DateTime checkIn, DateTime checkOut)
        {

            this.checkIn = checkIn;
            this.checkOut = checkOut;

            // One period doesn't fall under one season so this isn't applicable
            //this.season = DetermineSeason();
            dates = new List<DateTime>();   
            // populates list with all dates in the period
            DateTime start = checkIn;
            for (int i = CheckIn.Day; i < CheckOut.Day; i++)
            {
                dates.Add(start);
                start = start.AddDays(1);
            }
        }

        public bool Overlap(Period other)
        {

            bool result = true;

            if (CheckOut.CompareTo(other.CheckIn) <= 0 || CheckIn.CompareTo(other.CheckOut) >= 0)
            {
                result = false;
            }else
            {
                result = true;
            }

            return result;

        }

        public Season DetermineSeason(DateTime d)
        {
            
            if (d.Day < 7)
            {
                return Season.offSeason;
            }
            else if (d.Day > 7 && d.Day <= 15)
            {
                return Season.midSeason;
            }
            else
            {
                return Season.peakSeason;
            }
        }

        public int numDays()
        {
            // use built in functions !!!
            int days = checkOut.Day - checkIn.Day;
            return days;
        }
        public static DateTime ToDateTime(int day, int month, int year)
        {
            return new DateTime(day, month, year);
        }

    }
}
