using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rentalbase.Models
{
    public class Property
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PropertyID { get; set; }
        public string Address { get; set; }
        public double RentAmount { get; set; }
        public double Value { get; set; }
        public double Tax { get; set; }

        public virtual ICollection<Workorder> Workorders { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}