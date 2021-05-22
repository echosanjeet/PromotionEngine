using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Model
{
    public class Promotions : IList<Promotion>
    {
        List<Promotion> _promotions;

        public Promotions(List<Promotion> promotions)
        {
            _promotions = promotions;
        }

        public Promotion this[int index] 
        { 
            get => _promotions[index]; 
            set => _promotions[index] = value; 
        }

        public int Count => _promotions.Count;

        public bool IsReadOnly => false;

        public void Add(Promotion item)
        {
            _promotions.Add(item);
        }

        public void Clear()
        {
            _promotions.Clear();
        }

        public bool Contains(Promotion item)
        {
            return _promotions.Contains(item);
        }

        public void CopyTo(Promotion[] array, int arrayIndex)
        {
            _promotions.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Promotion> GetEnumerator()
        {
            foreach (var _promo in _promotions)
            {
                yield return _promo;
            }
        }

        public int IndexOf(Promotion item)
        {
            return _promotions.IndexOf(item);
        }

        public void Insert(int index, Promotion item)
        {
            _promotions.Insert(index, item);
        }

        public bool Remove(Promotion item)
        {
            return _promotions.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _promotions.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
