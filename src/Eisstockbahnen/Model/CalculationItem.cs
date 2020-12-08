using EisstockbahnenWebModel;

namespace Eisstockbahnen.Model
{
    public class CalculationItem
    {
        public int Bought { get; set; }
        public int Sold { get; set; }

        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }

        public double Profit { get; set; }

        public ProductModel Product { get; set; }

        public CalculationItem(ProductModel product) : this(0, 0, 0, 0, product)
        {
        }

        public CalculationItem(int bought, int sold, double buyPrice, double sellPrice, ProductModel product)
        {
            Bought = bought;
            Sold = sold;

            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            Product = product;
        }
    }
}
