using System;
using Progress.Shared.Domain.Errors.Dto;

namespace Progress.Shared.Domain.Errors
{
    public class Order
    {
        protected Identifier id;
        protected OrderNumber number;
        protected List<OrderItem> orderItems;
        protected DateTime date;

        protected Order(Identifier id, OrderNumber number, DateTime date)
        {
            this.id = id;
            this.number = number;
            this.orderItems = new List<OrderItem>();
            this.date = date;
        }

        public static Field<Order>? Create(Field<Identifier> id, Field<OrderNumber> number, Field<DateTime> date)
        {
            DateTime now = new DateTime();

            if (date.GetValue() < now)
            {
                date.AddError("Order Date should be more than now");
            }

            if (date.IsValid())
            {
                return id.To(new Order(id.GetValue(), number.GetValue(), date.GetValue()));
            }

            return null;
        }

        public void AddItem(Field<OrderItem> item)
        {
            if (this.orderItems.Count() > 10)
            {
                item.AddError("Order have max 10 items");
            }

            if (item.IsValid())
            {
                this.orderItems.Add(item.GetValue());
            }
        }
    }
}

