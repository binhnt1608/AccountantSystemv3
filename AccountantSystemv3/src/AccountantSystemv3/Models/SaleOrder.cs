using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccountantSystemv3.Models
{
    public class SaleOrder
    {
        [Key]
        [Display(Name = "Sale Order #")]
        public int SaleOrderID { get; set; }

        [Display(Name = "Employee #")]
        public int EmployeeID { get; set; }

        [Display(Name = "Customer #")]
        public int CustomerID { get; set; }

        [Display(Name = "Customer PO")]
        public string CustomerPO { get; set; }

        [Display(Name = "Amount")]
        public float SaleOrderAmount { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date, ErrorMessage = "Date Time is invalid")]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy:0}", ApplyFormatInEditMode = true)]
        public DateTime SaleOrderDate { get; set; }

        //1-m employee customer
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

    }
}
