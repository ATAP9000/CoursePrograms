#nullable disable
namespace Entities
{
    public class Refer
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public string Client { get; set; }
        public string Address { get; set; }
        public string IVACondition { get; set; }
        public string SaleCondition { get; set; }
        public string Detail { get; set; }
        public DateTime DeliverDate { get; set; }
        public decimal Total { get; set; }
    }
}
