using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericMethods
{
    interface ICache<T>
    {
        T Get(string key);
        void Insert(string key, T value);
        void Update(string key, T value);
        void Delete(string key);
    }

    public class Cache<T>:ICache<T>
    {
        
        public T Get(string key)
        {
            throw new NotImplementedException();
        }

        public void Insert(string key, T value)
        {
            throw new NotImplementedException();
        }

        public void Delete(string key)
        {
            throw new NotImplementedException();
        }

        public void Update(string key, T value)
        {
            throw new NotImplementedException();
        }

        public void Insert(string cacheKey, object value)
        {
            throw new NotImplementedException();
        }
    }
}
