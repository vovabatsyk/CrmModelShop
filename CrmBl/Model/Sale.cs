namespace CrmBl.Model
{
    public class Sale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CheCkId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Check Check { get; set; }
    }
}
