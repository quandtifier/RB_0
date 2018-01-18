using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rentalbase.Models
{
    public enum Rating
    {
        A, B, C, D, F
    }
    public class Tenant
    {
        public int TenantID { get; set; }
        public int PropertyID { get; set; }
        public string Phone { get; set; }
        public int NumOccupants { get; set; }
        public DateTime DateIn { get; set; }
        public double BalanceOwed { get; set; }

        public virtual ICollection<Workorder> Workorders { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}