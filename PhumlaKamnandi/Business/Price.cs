using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    /*
     * Class to determine the cost associated with a booking
     */
    public class Price
    {
        private float total;
        private Period date;
        private float seasonCost;

        public Price() { }
        public Price(Period date) 
        { 
            this.date = date; 
            determineSeasonPrice();
            this.total = seasonCost * date.numDays();
        }

        public Price(int total, Period date) { this.total = total; this.date = date; }

        public void determineSeasonPrice()
        {
            Period.Season season = date.DetermineSeason();
            switch (season)
            {
                case Period.Season.offSeason:
                    seasonCost = 550;
                    break;
                case Period.Season.midSeason:
                    seasonCost = 750;
                    break;
                case Period.Season.peakSeason:
                    seasonCost = 995;
                    break;
            }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
    }
}
