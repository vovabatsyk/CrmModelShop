using System;
using System.Collections.Generic;

namespace CRM_Bl.Model
{
    public class Check
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public DateTime Created { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public override string ToString() => $"№:{Id} created on {Created:dd.MM.YY hh:mm:ss}";
    }
}
