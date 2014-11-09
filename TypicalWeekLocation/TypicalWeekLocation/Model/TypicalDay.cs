using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypicalWeekLocation.Model
{
    public enum DayOfWeek { MON,TUE,WED,THU,FRI,SAT,SUN};

    class TypicalDay
    {
        private DayOfWeek day;
        private List<Slotime> popularSlotInTheDay;

        public TypicalDay(DayOfWeek day)
        {
            this.day = day;
            this.popularSlotInTheDay = new List<Slotime>();
        }

        public DayOfWeek Day
        {
            get { return day; }
            set { day = value; }
        }
        public List<Slotime> PopularSlotInTheDay
        {
            get { return popularSlotInTheDay; }
            set { popularSlotInTheDay = value; }
        }


    }
}
