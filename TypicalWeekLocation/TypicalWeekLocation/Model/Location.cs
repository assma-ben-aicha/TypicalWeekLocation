using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypicalWeekLocation.Model
{
    class Location
    {
        private double coordX;
        private double coordY;

        public Location(double x, double y)
        {
            this.coordX = x;
            this.coordY = y;
        }

        /**
         *  GETTER & SETTER
         **/

        public double CoordX
        {
            get { return coordX; }
            set { coordX = value; }
        }
        public double CoordY
        {
            get { return coordY; }
            set { coordY = value; }
        }
    }
}
