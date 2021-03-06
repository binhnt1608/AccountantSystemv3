﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AccountantSystemv3.Models
{
    public class ReservationPurchaseOrderInventory
    {
        public int PurchaseOrderID { get; set; }
        public int InventoryID { get; set; }

        //m-1 purchaseorder inventory
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
