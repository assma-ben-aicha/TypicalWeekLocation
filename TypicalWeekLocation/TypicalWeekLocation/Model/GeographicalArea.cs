using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypicalWeekLocation.Model
{
    class GeographicalArea
    {
        private int id;
        private string city;
        private int zipCode;
        private string adress;
        private Location center;

        public GeographicalArea(string city,int zipcode,string adress,Location center)
        {

            //TODO to be implemented for id

            this.city = city;
            this.zipCode = zipcode;
            this.adress = adress;
            this.center = center;
        }

        public Boolean thisLocationIsInThisArea(Location location)
        {
            //TODO to be implemented
            return false;
        }

        /**
         *  GETTER & SETTER
         **/

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public Location Center
        {
            get { return center; }
            set { center = value; }
        }

    }
}
