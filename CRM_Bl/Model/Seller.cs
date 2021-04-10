using System.Collections.Generic;

namespace CRM_Bl.Model
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Check> Checks;
        public override string ToString() => Name;
    }
}
