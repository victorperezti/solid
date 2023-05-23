using MediatR;
using System;

namespace Daycoval.Solid.Domain.Entities.DomainObject
{
    public abstract class Event : INotification
    {
        public DateTime DataOcorrencia => DateTime.Now;
    }
}