using System;
using Progress.Shared.Domain.Abstract;

namespace Progress.Shared.Domain
{
    public class Aggregate : Entity, IAggregate
    {
        protected List<IDomainEvent<IAggregate>> domainEvents;

        public Aggregate(string id) : base(id)
        {
            this.domainEvents = new List<IDomainEvent<IAggregate>>();
        }

        public List<IDomainEvent<IAggregate>> GetDomainEvents()
        {
            return this.domainEvents;
        }
    }
}

