using Chain_of_Responsability.Abstractions;

namespace Chain_of_Responsability.Models.Discounts
{
    internal class DiscountPerItemEqualsTo(string item, int discountRate) : DiscountBase(discountRate)
    {
        public string Item { get; set; } = item;

        public override double Discount(Order order)
        {
            var itemExists = order.Items.FirstOrDefault(x => x.Name.Equals(Item));

            if (itemExists is not null) return order.Value * (DiscountRate / 100);

            if (Next is not null) return Next.Discount(order);

            return 0;
        }
    }
}
