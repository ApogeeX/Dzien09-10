using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
    internal class Repository<T> where T : IEntity, new()
    {
        private List<T> data = new List<T>();

        public void AddElement(T element)
        {
            if (element != null)
            {
                data.Add(element);
            }
        }

        public T GetElement(int index)
        {
            if (index < data.Count && index > -1)
            {
                return data[index];
            }
            else
            {
                return default;
            }
        }
    }

    public class Repository<Tkey, TValue>  
    {
        private Dictionary<Tkey, TValue> data = new Dictionary<Tkey, TValue>();

        public void AddElement(Tkey key, TValue value)
        {
            if (data != null)
            {
                data.Add(key, value);
            }
        }

        public TValue GetElement(Tkey key)
        {
            if (data.TryGetValue(key, out TValue value))
            {
                return value;
            }
            else
            {
                return default;
            }
        }
    }

}
