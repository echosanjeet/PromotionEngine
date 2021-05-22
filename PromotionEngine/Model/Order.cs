using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class Order
    {
        public int Id { get; set; }

        public List<Product> Products { get; set; }

        public Order(int _id, List<Product> _products)
        {
            Id = _id;
            Products = _products;
        }
    }
}
