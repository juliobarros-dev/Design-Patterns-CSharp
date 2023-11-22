using State.Abstractions;

namespace State.Models.States
{
    internal class Pending : IOrderState
    {
        public void ApplyDiscount(Order order) => order.Value -= (order.Value * 0.05);
        public void Approve(Order order) => order.State = new Approved();
        public void Refuse(Order order) => order.State = new Refused();
        public void Complete(Order order) => throw new Exception("Pending orders can't be completed.");
    }
}
