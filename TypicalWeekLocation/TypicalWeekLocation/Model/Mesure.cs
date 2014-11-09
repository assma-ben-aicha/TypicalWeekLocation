using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypicalWeekLocation.Model
{
    class Mesure
    {
        private DateTime date;
        private Location location;

        public Mesure(DateTime date, Location location)
        {
            this.date = date;
            this.location = location;
        }

        /**
         *  GETTER & SETTER
         **/

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

    }
}
