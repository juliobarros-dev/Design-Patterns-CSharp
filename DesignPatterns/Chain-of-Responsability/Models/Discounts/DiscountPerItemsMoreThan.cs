using Chain_of_Responsability.Abstractions;

namespace Chain_of_Responsability.Models.Discounts
{
    internal class DiscountPerItemsMoreThan(int quantity, int discountRate) : IDiscount
    {
        public int Quantity { get; set; } = quantity;
        public double DiscountRate { get; set; } = discountRate;
        public IDiscount? Next { get; set; }

        public double Discount(Order order)
        {
            var discount = 0.00;

            if (order.Items.Count > Quantity)
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
