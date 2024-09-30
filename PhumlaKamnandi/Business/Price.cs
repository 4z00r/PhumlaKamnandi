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
        private Period date;
        private int numBeds;
        private float discount;
        private int cost;

        public Price() { }
        public Price(int cost, Period date) { this.cost = cost; this.date = date; }
        public float determinePrice()
        {
            Period.Season season = date.DetermineSeason();
            switch (season)
            {
                case Period.Season.offSeason:
                    cost = 550;
                    break;
                case Period.Season.midSeason:
                    cost = 750;
                    break;
                case Period.Season.peakSeason:
                    cost = 995;
                    break;
            }
            return cost;
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
