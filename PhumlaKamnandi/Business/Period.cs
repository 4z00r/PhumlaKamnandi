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

        public Period(DateTime checkIn, DateTime checkOut)
        {

            this.checkIn = checkIn;
            this.checkOut = checkOut;

            this.season = DetermineSeason(); 
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

        public Season DetermineSeason()
        {
            // take preference of checkin Day
            if (checkIn.Day < 7)
            {
                return Season.offSeason;
            }
            else if (checkIn.Day > 7 && checkIn.Day <= 15)
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
