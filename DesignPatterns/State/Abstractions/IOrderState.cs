using State.Models;

namespace State.Abstractions
{
    internal interface IOrderState
    {
        void ApplyDiscount(Order order);
        void Approve(Order order);
        void Refuse(Order order);
        void Complete(Order order);
    }
}
