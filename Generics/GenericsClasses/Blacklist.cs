using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Interfaces;

namespace Generics.GenericsClasses
{
    public class Blacklist<T> where T : IBlacklist
    {
        private readonly IRepositorioBase<T> _repository;

        public Blacklist(IUnitOfWork unitOfWork)
        {
            _repository = unitOfWork.CriarRepositorio<T>();
        }

        public IEnumerable<string> ObterTodos()
        {
            return from blacklist in _repository.ObterTodos()
                   select blacklist.Palavra;
        }
    }
}
