using State.Abstractions;

namespace State.Models.States
{
    internal class Completed : IOrderState
    {
        public void ApplyDiscount(Order order) => throw new Exception("Completed payments does not receive any discounts.");
        public void Approve(Order order) => throw new Exception("Completed orders can't be approved.");
        public void Refuse(Order order) => throw new Exception("Completed orders can't be refused.");
        public void Complete(Order order) => throw new Exception("Order already completed.");
    }
}
