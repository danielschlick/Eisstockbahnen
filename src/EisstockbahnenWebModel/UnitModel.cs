using System.Collections.Generic;

namespace EisstockbahnenWebModel
{
    public class UnitModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductModel> Products { get; set; }
    }
}
