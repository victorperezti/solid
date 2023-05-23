namespace Daycoval.Solid.Infrastructure.UoW;

public class UnitOfWork : IUnitOfWork
{
    private readonly DaycovalContext _daycovalContexto;

    public UnitOfWork(DaycovalContext context)
    {
        _daycovalContexto = context;
    }

    public bool Commit()
    {
        return _daycovalContexto.SaveChanges() > 0;
    }

    public void Dispose()
    {
        _daycovalContexto.Dispose();
    }
}