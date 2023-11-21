using Chain_of_Responsability.Abstractions;

namespace Chain_of_Responsability.Models.Discounts
{
    internal class DiscountPerItemEqualsTo(string item, int discountRate) : IDiscount
    {
        public string Item { get; set; } = item;
        public double DiscountRate { get; set; } = discountRate;
        public IDiscount? Next { get; set; }

        public double Discount(Order order)
        {
            var discount = 0.00;

            var itemExists = order.Items.FirstOrDefault(x => x.Name.Equals(Item));

            if (itemExists is not null)
            {
                discount = order.Value * (DiscountRate / 100);
            }

            if (Next is not null)
            {
                discount = Next.Discount(order);
            }

            return discount;
        }
    }
}
