using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generics.Interfaces;
using Generics.Model;

namespace Generics.GenericsClasses
{
    public class BlacklistPerguntas
    {
        private readonly IRepositorioBase<Pergunta> _repository;

        public BlacklistPerguntas(IUnitOfWork unitOfWork)
        {
            _repository = unitOfWork.CriarRepositorio<Pergunta>();
        }

        public IEnumerable<string> ObterTodos()
        {
            return from blacklist in _repository.ObterTodos()
                   select blacklist.Texto;
        }
    }
}
