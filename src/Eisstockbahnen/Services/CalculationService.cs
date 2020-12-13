using Eisstockbahnen.Model;
using System.Collections.Generic;

namespace Eisstockbahnen.Services
{
    public class CalculationService
    {
        public List<CalculationItem> CalculateItems(List<CalculationItem> calculationItems)
        {
            foreach (var item in calculationItems)
            {
                item.Profit = item.SellPrice * item.Sold - item.BuyPrice * item.Bought;
            }

            return calculationItems;
        }
    }
}
