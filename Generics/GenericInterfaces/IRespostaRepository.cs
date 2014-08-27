using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Model;

namespace Generics.GenericInterfaces
{
    interface IRespostaRepository
    {
        IEnumerable<Resposta> GetPerguntas();
        Resposta GetPergunta(int id);
        void Add(Resposta pergunta);
    }
}
