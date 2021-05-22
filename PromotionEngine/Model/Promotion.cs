using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class Promotion
    {
        public int Id { get; set; }

        public Dictionary<string, int> PromotionInfo { get; set; }

        public decimal PromotionPrice { get; set; }

        public Promotion(int _id, Dictionary<string, int> _promotionInfo, decimal _promotionPrice)
        {
            Id = _id;
            PromotionInfo = _promotionInfo;
            PromotionPrice = _promotionPrice;
        }
    }
}
