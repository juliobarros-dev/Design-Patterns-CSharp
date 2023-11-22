using State.Abstractions;

namespace State.Models.States
{
    internal class Refused : IOrderState
    {
        public void ApplyDiscount(Order order) => throw new Exception("Refused payments does not receive any discounts.");
        public void Approve(Order order) => throw new Exception("Refused orders can't be approved.");
        public void Refuse(Order order) => throw new Exception("Order already refused.");
        public void Complete(Order order) => throw new Exception("Refused orders can't be completed.");
    }
}
