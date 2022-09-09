using System;
namespace Progress.Shared.Domain.Errors.Dto
{
    public class OrderItemDto
    {
        public readonly Field<string> id;
        public readonly Field<float> price;

        public OrderItemDto(string id, float price)
        {
            this.id = new Field<string>(id, null);
            this.price = new Field<float>(price, null);
        }

        public bool IsValid()
        {
            return this.id.IsValid() && this.price.IsValid();
        }
    }
}

