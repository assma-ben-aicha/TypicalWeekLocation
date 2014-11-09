using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypicalWeekLocation.Model
{
    class LocationRegistration
    {
        private List<GeographicalArea> locationregistred;

        public LocationRegistration()
        {
            locationregistred = new List<GeographicalArea>();
        }

        public int getIdLocation(Location location)
        {
            // TODO to be implemented
            return 0;
        }

        public GeographicalArea getGeographicaById(int id)
        {
            //TODO to be implemented
            return null;
        }

        public List<GeographicalArea> Locationregistred
        {
            get { return locationregistred; }
            set { locationregistred = value; }
        }
    }
}
