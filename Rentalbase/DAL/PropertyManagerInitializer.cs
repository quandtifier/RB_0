using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Rentalbase.Models;

namespace Rentalbase.DAL
{
    public class PropertyManagerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PropertyManagerContext>
    {
        protected override void Seed(PropertyManagerContext context)
        {
            var properties = new List<Property>
            {
                //lots of data here
                new Property{ PropertyID=1,Address="1234 West Dr",RentAmount=1357.99,Value=250000.00, Tax=2500.00},
                new Property{ PropertyID=2,Address="987 North St",RentAmount=2300.00,Value=330000.00, Tax=3900.00},
                new Property{ PropertyID=3,Address="8729 South Way",RentAmount=1000.00,Value=200000.00, Tax=1900.00},
                new Property{ PropertyID=4,Address="56569 East Pl",RentAmount=2900.00,Value=380000.00, Tax=4000.00}
            };
            properties.ForEach(s => context.Properties.Add(s));
            context.SaveChanges();

            var tenants = new List<Tenant>
            {
                new Tenant{PropertyID=1,Phone="123-456-7890", NumOccupants=4, DateIn=DateTime.Parse("2011-09-14"), BalanceOwed=0},
                new Tenant{PropertyID=4,Phone="111-222-3333", NumOccupants=2, DateIn=DateTime.Parse("2001-12-04"), BalanceOwed=14.32},
                new Tenant{PropertyID=2,Phone="444-444-4444", NumOccupants=6, DateIn=DateTime.Parse("2016-01-30"), BalanceOwed=0}
            };
            tenants.ForEach(s => context.Tenants.Add(s));
            context.SaveChanges();
        
            var workorders = new List<Workorder>
            {
                new Workorder{PropertyID=1, Description="Sink Repairs", Cost=69.33, IsComplete=false, DatePlaced=DateTime.Parse("2017-09-03")},
                new Workorder{PropertyID=1, Description="Bathtub Repairs", Cost=199.33, IsComplete=true, DatePlaced=DateTime.Parse("2017-08-15")},
                new Workorder{PropertyID=4, Description="Carpet Cleaning", Cost=59.02, IsComplete=false, DatePlaced=DateTime.Parse("2001-08-01")},
                new Workorder{PropertyID=2, Description="Replace Range", Cost=800.00, IsComplete=true, DatePlaced=DateTime.Parse("2017-02-19")}

            };
            workorders.ForEach(s => context.Workorders.Add(s));
            context.SaveChanges();

            var invoices = new List<Invoice>
            {
                new Invoice{ TenantID=1, AmountPaid=1357.99, DatePaid=DateTime.Parse("2014-02-01") },
                new Invoice{ TenantID=1, AmountPaid=1357.99, DatePaid=DateTime.Parse("2014-03-01") },
                new Invoice{ TenantID=1, AmountPaid=1357.99, DatePaid=DateTime.Parse("2014-04-01") },
                new Invoice{ TenantID=1, AmountPaid=1357.99, DatePaid=DateTime.Parse("2014-05-01") },
                new Invoice{ TenantID=2, AmountPaid=2900.00, DatePaid=DateTime.Parse("2001-05-02") },
                new Invoice{ TenantID=2, AmountPaid=2900.00, DatePaid=DateTime.Parse("2001-06-03") },
                new Invoice{ TenantID=2, AmountPaid=2900.00, DatePaid=DateTime.Parse("2001-07-03") },
                new Invoice{ TenantID=2, AmountPaid=2900.00, DatePaid=DateTime.Parse("2001-05-01") },
                new Invoice{ TenantID=2, AmountPaid=59.02, DatePaid=DateTime.Parse("2001-08-01"), WorkorderID=3},
                new Invoice{ TenantID=3, AmountPaid=2300.00, DatePaid=DateTime.Parse("2015-05-01") },
                new Invoice{ TenantID=3, AmountPaid=2300.00, DatePaid=DateTime.Parse("2015-06-01") },

            };
            invoices.ForEach(s => context.Invoices.Add(s));
            context.SaveChanges();
        }
    }
}