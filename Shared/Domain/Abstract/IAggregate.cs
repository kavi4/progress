using System;
namespace Progress.Shared.Domain.Abstract
{
    public interface IAggregate : IEntity
    {
        public List<IDomainEvent<IAggregate>> GetDomainEvents();
    }
}

