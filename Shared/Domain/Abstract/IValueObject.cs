using System;
namespace Progress.Shared.Domain.Abstract
{
    public interface IValueObject
    {
        public bool Equals(object obj);
    }
}

