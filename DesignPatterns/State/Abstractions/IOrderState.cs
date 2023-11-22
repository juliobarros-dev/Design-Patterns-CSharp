using State.Models;

namespace State.Abstractions
{
    internal interface IOrderState
    {
        void ApplyDiscount(Order order);
    }
}
