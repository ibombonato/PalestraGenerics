namespace Generics.Interfaces
{
    public interface IUnitOfWork
    {
        IRepositorioBase<T> CriarRepositorio<T>();
    }

    public class UnitOfWork : IUnitOfWork
    {
        public IRepositorioBase<T> CriarRepositorio<T>()
        {
            throw new System.NotImplementedException();
        }
    }
}