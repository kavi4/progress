using System;
using Progress.Shared.Domain.Errors.Dto;

namespace Progress.Shared.Domain.Errors
{
    public class Identifier
    {
        protected string value;

        protected Identifier(string id)
        {
            this.value = id;
        }

        public static Field<Identifier>? Create(Field<string> id)
        {
            if (id.GetValue().Length > 255)
            {
                id.AddError("Id must be less 255 symbols");
            }

            if (id.GetValue().Length < 16)
            {
                id.AddError("Id must be more 16 symbols");
            }

            if (id.IsValid())
            {
                return id.To(new Identifier(id.GetValue()));
            }

            return null;
        }
    }
}

