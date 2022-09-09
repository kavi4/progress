using System;
using Progress.Shared.Domain.Errors.Dto;

namespace Progress.Shared.Domain.Errors
{
    public class Price
    {
        protected float value;

        public Price(float price)
        {
            this.value = price;
        }

        public static Field<Price>? Create(Field<float> price)
        {
            if (price.GetValue() < 0)
            {
                price.AddError("Price cant be less zero");
            }

            if (price.IsValid())
            {
                return price.To(new Price(price.GetValue()));
            }

            return null;
        }
    }
}

