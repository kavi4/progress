using System;
using Progress.Shared.Domain.Errors.Dto;

namespace Progress.Shared.Domain.Errors
{
    public class Programm
    {
        public Programm()
        {
            OrderDto orderDto = new OrderDto("uuid", "number", new DateTime(), new List<OrderItemDto>());

            Order? order = this.createOrder(orderDto);
        }

        public Order? createOrder(OrderDto orderDto)
        {
            Field<Identifier>? id = Identifier.Create(orderDto.id);
            Field<OrderNumber>? number = OrderNumber.Create(orderDto.number);
            Field<DateTime> date = orderDto.date.To(orderDto.date.GetValue());

            if (id is object && number is object)
            {
                Field<Order>? order = Order.Create(id, number, date);
                
                if (order is object)
                {
                    foreach (OrderItemDto item in orderDto.orderItems.GetValue())
                    {
                        Field<Identifier>? itemId = Identifier.Create(item.id);
                        Field<Price>? itemPrice = Price.Create(item.price);

                        if (itemId is object && itemPrice is object)
                        {
                            Field<OrderItem> orderItem = OrderItem.Create(itemId, itemPrice);

                            if (orderItem is object)
                            {
                                order.GetValue().AddItem(orderItem);
                            }
                        }
                    }

                    if (order.IsValid())
                    {
                        return order.GetValue();
                    }
                }
            }

            return null;
        }
    }
}

