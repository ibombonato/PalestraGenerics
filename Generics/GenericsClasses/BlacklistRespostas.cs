using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Interfaces;
using Generics.Model;

namespace Generics.GenericsClasses
{
    public class BlacklistRespostas
    {
        private readonly IRepositorioBase<Resposta> _repository;

        public BlacklistRespostas(IUnitOfWork unitOfWork)
        {
            _repository = unitOfWork.CriarRepositorio<Resposta>();
        }

        public IEnumerable<string> ObterTodos()
        {
            return from blacklist in _repository.ObterTodos()
                   select blacklist.Texto;
        }
    }
}
