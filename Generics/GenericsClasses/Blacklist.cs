using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics.Interfaces;
using Generics.Model;

namespace Generics.Interfaces
{
    public class Blacklist<T> where T : IBlacklistEntity
    {
        private readonly IRepositorioBase<T> _repository;

        public Blacklist(IUnitOfWork unitOfWork)
        {
            _repository = unitOfWork.CriarRepositorio<T>();
        }

        public IEnumerable<string> ObterTodos()
        {
            return from blacklist in _repository.ObterTodos()
                   select blacklist.Texto;
        }
    }

    public class ConsumoBlacklist
    {
        public IEnumerable<string> ConsumirBlacklist()
        {
            var blackList = new Blacklist<Pergunta>(new UnitOfWork());
            return blackList.ObterTodos();
        }
    }

    public class ConsumoBlacklist<T> where T : IBlacklistEntity
    {
        public IEnumerable<string> ConsumirBlacklist()
        {
            var blackList = new Blacklist<T>(new UnitOfWork());
            return blackList.ObterTodos();
        }
    }

    //public class AssertException
    //{
    //    public static async Task ThrowsAsync<TException>(Func<Task> func) where TException : Exception
    //    {
    //        var expected = typeof(TException);
    //        Type actual = null;
    //        try
    //        {
    //            await func();
    //        }
    //        catch (Exception e)
    //        {
    //            actual = e.GetType();
    //        }
    //        Assert.Equal(expected, actual);
    //    }
    //}
}
