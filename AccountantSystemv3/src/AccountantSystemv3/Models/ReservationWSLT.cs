using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountantSystemv3.Models
{
    public class ReservationWSLT
    {
        public int ScheduleID { get; set; }

        public int LaborTypeID { get; set; }

        //m-1 workschedule labortype
        public virtual WorkSchedule WorkSchedule { get; set; }

        public virtual LaborType LaborType { get; set; }
    }
}
