﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
<<<<<<< HEAD
        public int ShipVia { get; set; }
        public decimal Freight { get; set; }
=======
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
>>>>>>> 4eb4035997ec1071d72431d4216e0571285cccce
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        //public Order order { get; set; }
    }
}
