using System.Collections.Generic;

namespace CRM_Bl.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public override string ToString() => Name;
    }
}
