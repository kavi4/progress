using System;
using Progress.Shared.Domain.Errors.Dto;

namespace Progress.Shared.Domain.Errors
{
    public class OrderItem
    {
        protected Identifier id;
        protected Price price;

        public OrderItem(Identifier id, Price price)
        {
            this.id = id;
            this.price = price;
        }

        public static Field<OrderItem> Create(Field<Identifier> id, Field<Price> price)
        {
            return id.To(new OrderItem(id.GetValue(), price.GetValue()));
        }
    }
}

