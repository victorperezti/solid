namespace Daycoval.Solid.Infrastructure.UoW;

public interface IUnitOfWork : IDisposable
{
    bool Commit();
}