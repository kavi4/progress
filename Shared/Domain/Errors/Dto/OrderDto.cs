using System;
namespace Progress.Shared.Domain.Errors.Dto
{
    public class OrderDto
    {
        public readonly Field<string> id;
        public readonly Field<string> number;
        public readonly Field<DateTime> date;
        public readonly Field<List<OrderItemDto>> orderItems;

        public OrderDto(string id, string number, DateTime date, List<OrderItemDto> orderItems)
        {
            this.id = new Field<string>(id, null);
            this.number = new Field<string>(number, null);
            this.date = new Field<DateTime>(date, null);
            this.orderItems = new Field<List<OrderItemDto>>(orderItems, null);
        }

        public bool IsValid()
        {
            return this.id.IsValid() && this.number.IsValid() && this.date.IsValid() && this.orderItems.IsValid();
        }
    }
}

