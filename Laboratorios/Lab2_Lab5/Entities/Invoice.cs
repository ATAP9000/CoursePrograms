#nullable disable
namespace Entities
{
    public class Invoice
    {
        public string Type { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public string Client { get; set; }
        public string Address { get; set; }
        public string IVACondition { get; set; }
        public string SaleCondition { get; set; }
        public string Detail { get; set; }
        public decimal Total { get; set; }
    }
}
