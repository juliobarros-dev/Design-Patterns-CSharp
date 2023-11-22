using State.Abstractions;

namespace State.Models.States
{
    internal class Pending : IOrderState
    {
        public void ApplyDiscount(Order order) => order.Value -= (order.Value * 0.05);
        // Change state logic, now our discounts know how to apply the discount and what is the next state
        public void Approve(Order order) => order.State = new Approved();
        public void Refuse(Order order) => order.State = new Refused();
        public void Complete(Order order) => throw new Exception("Pending orders can't be completed.");
    }
}
