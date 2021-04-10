using System.Collections.Generic;

namespace CrmBl.Model
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Check> Checks;
        public override string ToString() => Name;
    }
}
