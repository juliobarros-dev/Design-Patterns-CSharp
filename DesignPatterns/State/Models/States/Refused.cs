using State.Abstractions;

namespace State.Models.States
{
    internal class Refused : IOrderState
    {
        public void ApplyDiscount(Order order) => throw new Exception("Refused payments does not receive any discounts.");
    }
}
