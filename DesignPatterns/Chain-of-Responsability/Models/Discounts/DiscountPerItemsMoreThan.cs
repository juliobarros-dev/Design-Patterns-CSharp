using Chain_of_Responsability.Abstractions;

namespace Chain_of_Responsability.Models.Discounts
{
    internal class DiscountPerItemsMoreThan(int quantity, int discountRate) : DiscountBase(discountRate)
    {
        public int Quantity { get; set; } = quantity;

        public override double Discount(Order order)
        {
            if (order.Items.Count > Quantity) return order.Value * (DiscountRate / 100);

            if (Next is not null) return Next.Discount(order);

            return 0;
        }
    }
}
