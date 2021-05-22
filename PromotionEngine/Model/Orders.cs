using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class Orders : IList<Order>
    {
        List<Order> _Orders;

        public Orders(List<Order> Orders)
        {
            _Orders = Orders;
        }

        public Order this[int index]
        {
            get => _Orders[index];
            set => _Orders[index] = value;
        }

        public int Count => _Orders.Count;

        public bool IsReadOnly => false;

        public void Add(Order item)
        {
            _Orders.Add(item);
        }

        public void Clear()
        {
            _Orders.Clear();
        }

        public bool Contains(Order item)
        {
            return _Orders.Contains(item);
        }

        public void CopyTo(Order[] array, int arrayIndex)
        {
            _Orders.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Order> GetEnumerator()
        {
            foreach (var _promo in _Orders)
            {
                yield return _promo;
            }
        }

        public int IndexOf(Order item)
        {
            return _Orders.IndexOf(item);
        }

        public void Insert(int index, Order item)
        {
            _Orders.Insert(index, item);
        }

        public bool Remove(Order item)
        {
            return _Orders.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _Orders.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
