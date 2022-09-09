using System;
namespace Progress.Shared.Domain.Abstract
{
    public interface IDomainEvent<T> : IValueObject
    {
        public T GetOwner();

        public string GetEventType();

        public DateTime GetCreatedAt();
    }
}

