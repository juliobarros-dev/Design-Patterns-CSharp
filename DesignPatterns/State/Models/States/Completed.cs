using State.Abstractions;

namespace State.Models.States
{
    internal class Completed : IOrderState
    {
        public void ApplyDiscount(Order order) => throw new Exception("Completed payments does not receive any discounts.");
    }
}
