using System;
using Progress.Shared.Domain.Abstract;

namespace Progress.Shared.Domain
{
    public class Entity : IEntity
    {
        protected string id;

        public Entity(string id)
        {
            this.id = id;
        }

        public string GetId()
        {
            return this.id;
        }
    }
}

