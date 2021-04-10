﻿using System.Collections.Generic;

namespace CrmBl.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public override string ToString() => Name;
    }
}
