using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypicalWeekLocation.Model
{
    class Slotime
    {
        private int startHour;
        private int endHour;
        private Boolean idPopular;
        private int frequency;
        private GeographicalArea location;

        public Slotime(int start,int end,Boolean polarity,int frequency,GeographicalArea location)
        {
            this.startHour = start;
            this.endHour = end;
            this.idPopular = polarity;
            this.frequency = frequency;
            this.location = location;
        }


        public int StartHour
        {
            get { return startHour; }
            set { startHour = value; }
        }
        public int EndHour
        {
            get { return endHour; }
            set { endHour = value; }
        }
        public Boolean IdPopular
        {
            get { return idPopular; }
            set { idPopular = value; }
        }
        internal GeographicalArea Location
        {
            get { return location; }
            set { location = value; }
        }
        public int Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }
    }
}
