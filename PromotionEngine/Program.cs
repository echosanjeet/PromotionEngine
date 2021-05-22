using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main()
        {
            ProductService productService = new ProductService();

            Orders orders = new Orders(new List<Order>()
            {
                new Order(1, new List<Product>()
                {
                    new Product("A"),
                    new Product("B"),
                    new Product("C")
                }),
                new Order(2, new List<Product>()
                {
                    new Product("A"), new Product("A"), new Product("A"), new Product("A"), new Product("A"),
                    new Product("B"), new Product("B"), new Product("B"), new Product("B"), new Product("B"),
                    new Product("C")
                    }),
                new Order(3, new List<Product>()
                {
                    new Product("A"), new Product("A"), new Product("A"),
                    new Product("B"), new Product("B"), new Product("B"), new Product("B"), new Product("B"),
                    new Product("C"),
                    new Product("D")
                })
            });

            foreach (Order order in orders)
            {
                List<decimal> promotionPrices = productService.GetPromotions()
                    .Select(promo => productService.GetDiscountedPrice(order, promo))
                    .ToList();

                decimal originalPrice = order.Products.Sum(x => x.Price);
                
                decimal promotionPrice = promotionPrices.Sum();
                
                Console.WriteLine($"" +
                    $"OrderID: {order.Id} => " +
                    $"Original Price: {originalPrice.ToString("0.00")} | " +
                    $"Discount: {promotionPrice.ToString("0.00")} | " +
                    $"Final Price: {(originalPrice - promotionPrice).ToString("0.00")}");
            }
        }

        
    }
}
