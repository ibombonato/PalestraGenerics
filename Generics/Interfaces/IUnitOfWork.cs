namespace Generics.Interfaces
{
    public interface IUnitOfWork
    {
        IRepositorioBase<T> CriarRepositorio<T>();
    }
}