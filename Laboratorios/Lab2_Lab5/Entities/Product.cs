#nullable disable
namespace Entities
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal CostPrice { get; set; }
        public double Margin { get; set; }
        public double IVA { get; set; }
        public decimal GrossPrice { get { return CostPrice; } }
        public decimal SellingPrice { get { return CostPrice * (decimal)IVA * (decimal)Margin ; } } 
        public string Provider { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
    }
}
