using Daycoval.Solid.Domain.Entities.DomainObject;
using Daycoval.Solid.Infrastructure.UoW;
using MediatR;

namespace Daycoval.Solid.Application;

public abstract class CommandHandler
{
    private readonly IMediator _mediator;
    private readonly IUnitOfWork _uow;

    public CommandHandler(IUnitOfWork uow, IMediator mediator)
    {
        this._mediator = mediator;
        _uow = uow;
    }

    public bool Commit()
    {
        if (_uow.Commit()) return true;

        return false;
    }

    public void PublishEvents(IList<Event> events)
    {
        events.ToList().ForEach(e => _mediator.Publish(e));
    }
}