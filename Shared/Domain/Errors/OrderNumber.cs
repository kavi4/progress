using System;
using Progress.Shared.Domain.Errors.Dto;

namespace Progress.Shared.Domain.Errors
{
    public class OrderNumber
    {
        protected string value;

        protected OrderNumber(string number)
        {
            this.value = number;
        }

        public static Field<OrderNumber>? Create(Field<string> number)
        {
            if (number.GetValue().Length != 8)
            {
                number.AddError("Number should be 8 symbols");
            }

            if (number.IsValid())
            {
                return number.To(new OrderNumber(number.GetValue()));
            }

            return null;
        }
    }
}

