using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AccountantSystemv3.Models
{
    public class InflowLALT
    {
        public int TimeCardID { get; set; }

        public int LaborTypeID { get; set; }

        //m-1 LaborType LaborAcquisition
        public virtual LaborType LaborType { get; set; }

        public virtual LaborAcquisition LaborAcquisition { get; set; }
    }
}
