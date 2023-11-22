using State.Abstractions;

namespace State.Models.States
{
    internal class Approved : IOrderState
    {
        public void ApplyDiscount(Order order) => order.Value -= (order.Value * 0.02);
    }
}
