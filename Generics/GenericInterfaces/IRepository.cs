using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericInterfaces
{
    interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T pergunta);
    }
}
