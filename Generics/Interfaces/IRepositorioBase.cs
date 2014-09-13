using System.Collections.Generic;

namespace Generics.Interfaces
{
    public interface IRepositorioBase<T>
    {
        IEnumerable<T> ObterTodos();
    }
}