using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypicalWeekLocation.Model
{
    class TypicalWeek
    {
        private TypicalDay[] tabDay;

        public TypicalWeek()
        {
            tabDay = new TypicalDay[6];
            tabDay[0] = new TypicalDay(DayOfWeek.MON);
            tabDay[1] = new TypicalDay(DayOfWeek.TUE);
            tabDay[2] = new TypicalDay(DayOfWeek.WED);
            tabDay[3] = new TypicalDay(DayOfWeek.THU);
            tabDay[4] = new TypicalDay(DayOfWeek.FRI);
            tabDay[5] = new TypicalDay(DayOfWeek.SAT);
            tabDay[6] = new TypicalDay(DayOfWeek.SUN);

        }

        public TypicalDay[] TabDay
        {
            get { return tabDay; }
            set { tabDay = value; }
        }


    }
}
