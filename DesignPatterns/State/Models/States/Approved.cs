using State.Abstractions;

namespace State.Models.States
{
    internal class Approved : IOrderState
    {
        public void ApplyDiscount(Order order) => order.Value -= (order.Value * 0.02);
        public void Approve(Order order) => throw new Exception("Order already approved.");
        public void Refuse(Order order) => throw new Exception("Approved orders can't be refused.");
        public void Complete(Order order) => order.State = new Completed();
    }
}
