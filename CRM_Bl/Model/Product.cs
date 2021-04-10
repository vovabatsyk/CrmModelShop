﻿using System.Collections.Generic;

namespace CRM_Bl.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }

        public override string ToString() => Name;
    }
}
