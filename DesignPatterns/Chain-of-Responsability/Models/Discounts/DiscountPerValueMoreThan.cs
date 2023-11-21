using Chain_of_Responsability.Abstractions;

namespace Chain_of_Responsability.Models.Discounts
{
    internal class DiscountPerValueMoreThan(double value, int discountRate) : IDiscount
    {
        public double Value { get; set; } = value;
        public double DiscountRate { get; set; } = discountRate;
        public IDiscount? Next { get; set; }

        public double Discount(Order order)
        {
            var discount = 0.00;

            if (order.Value > Value)
            {
                discount = order.Value * (DiscountRate / 100);
                
                return discount;
            }

            if (Next is not null)
            {
                discount = Next.Discount(order);
            }

            return discount;
        }
    }
}
