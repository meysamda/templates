namespace $safeprojectname$.Infrastructure.Data.Repositories
{
    public interface IRepository
    {
        IUnitOfWork UnitOfWork { get; }
    }
}