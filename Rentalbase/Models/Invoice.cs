using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rentalbase.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int TenantID { get; set; }
        public int WorkorderID { get; set; }
        public DateTime DatePaid { get; set; }
        public double AmountPaid { get; set; }
    }
}