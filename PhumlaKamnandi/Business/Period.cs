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

            //this.season; 
        }

        public bool Overlap(Period other)
        {

            if (DateTime.Compare(CheckOut, other.CheckIn) <= 0)
            {
                return false;
            }
            if (DateTime.Compare(CheckIn, other.CheckOut) >= 0)
            {
                return false;
            }

            return true;

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
            int days = checkOut.Day - checkIn.Day;
            return days;
        }
        public static DateTime ToDateTime(int day, int month, int year)
        {
            return new DateTime(day, month, year);
        }

    }
}
