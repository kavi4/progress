using System;
namespace Progress.Shared.Domain.Errors.Dto
{
    public class Field<T>
    {
        protected T value;
        protected List<string> errors;

        public Field(T value, List<string>? errors = null)
        {
            this.value = value;

            this.errors = errors == null ? new List<string>() : errors;
        }

        public void AddError(string error)
        {
            this.errors.Add(error);
        }

        public T GetValue()
        {
            return this.value;
        }

        public Field<Y> To<Y>(Y value)
        {
            return new Field<Y>(value, this.errors);
        }

        public bool IsValid()
        {
            return this.errors.Count() == 0;
        }
    }
}

