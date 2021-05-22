using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class ProductService : IProductService
    {
        public Promotions GetPromotions()
        {
            var discount_on_three = new Dictionary<string, int>();
            var discount_on_two = new Dictionary<string, int>();
            var discount_on_one = new Dictionary<string, int>();

            discount_on_three.Add("A", 3);
            discount_on_two.Add("B", 2);
            discount_on_one.Add("C", 1);
            discount_on_one.Add("D", 1);

            return new Promotions(new List<Promotion>()
            {
                new Promotion(1, discount_on_three, 130),
                new Promotion(2, discount_on_two, 45),
                new Promotion(3, discount_on_one, 30)
            });
        }

        public decimal GetTotalPrice(List<Product> products)
        {
            return products.Sum(x => x.Price);
        }

        public decimal GetDiscountedPrice(Order order, Promotion promotion)
        {
            decimal totalDiscount = 0M;

            var promotedProducts = order.Products
                                        .GroupBy(x => x.Id)
                                        .Where(group => promotion.PromotionInfo.Any(info => group.Key == info.Key && group.Count() >= info.Value))
                                        .Select(group => group.Count())
                                        .Sum();

            //get count of promoted products from promotion
            int promotionCount = promotion.PromotionInfo.Sum(x => x.Value);

            while (promotedProducts >= promotionCount)
            {
                totalDiscount += (order.Products.Where(x => x.Id == promotion.PromotionInfo.FirstOrDefault().Key).ToList()[0].Price * promotionCount) - promotion.PromotionPrice;
                promotedProducts -= promotionCount;
            }

            return totalDiscount;
        }
    }
}
