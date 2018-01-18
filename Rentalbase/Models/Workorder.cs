using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rentalbase.Models
{
    public class Workorder
    {
        public int WorkorderID { get; set; }
        public int PropertyID { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public DateTime DatePlaced { get; set; }
        public bool IsComplete { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}