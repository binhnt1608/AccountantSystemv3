using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountantSystemv3.Models
{
    public class InflowEmployeeWithholding
    {
        [Display(Name = "Marital Status ")]
        public int MaritalStatus { get; set; }

        [Display(Name = "Employee #")]
        public int EmployeeID { get; set; }

        //m-1 employee withholding
        public virtual Employee Employee { get; set; }
        public virtual Withholding Withholding { get; set; }
    }
}
