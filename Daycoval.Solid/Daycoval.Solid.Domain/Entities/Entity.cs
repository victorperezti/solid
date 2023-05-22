using System;

namespace Daycoval.Solid.Domain.Entities
{
    public class Entity
    {

        public Entity(Guid id)
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

    }
}
