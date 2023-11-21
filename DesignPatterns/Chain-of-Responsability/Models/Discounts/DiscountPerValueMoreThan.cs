using Chain_of_Responsability.Abstractions;

namespace Chain_of_Responsability.Models.Discounts
{
    internal class DiscountPerValueMoreThan(double value, int discountRate) : DiscountBase(discountRate)
    {
        public double Value { get; set; } = value;

        public override double Discount(Order order)
        {
            if (order.Value > Value) return order.Value * (DiscountRate / 100); ;

            if (Next is not null) return Next.Discount(order);

            return 0;
        }
    }
}
