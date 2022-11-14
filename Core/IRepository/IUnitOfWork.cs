namespace Core.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Commit();
    }
}
