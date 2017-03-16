using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AccountantSystemv3.Models
{
    public class InflowPurchaseInventory
    {
        public int InventoryID { get; set; }
        public int InventoryReceiptID { get; set; }

        //m-1 Inventory Purchase
        public virtual Inventory Inventory { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
