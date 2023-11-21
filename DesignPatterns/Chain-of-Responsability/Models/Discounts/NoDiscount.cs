using Chain_of_Responsability.Abstractions;

namespace Chain_of_Responsability.Models.Discounts
{
    internal class NoDiscount : IDiscount
    {
        public IDiscount? Next { get; set; }

        public double Discount(Order order)
        {
            return 0;
        }
    }
}
