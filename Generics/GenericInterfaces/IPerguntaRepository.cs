using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Model;

namespace Generics.GenericInterfaces
{
    interface IPerguntaRepository
    {
        IEnumerable<Pergunta> GetAllPerguntas();
        Pergunta GetPergunta(int id);
        void Add(Pergunta pergunta);
    }
}
