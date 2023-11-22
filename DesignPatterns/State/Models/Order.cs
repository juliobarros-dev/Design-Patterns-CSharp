using State.Abstractions;
using State.Models.States;

namespace State.Models
{
    internal class Order(double value)
    {
        internal IOrderState State = new Pending();
        internal double Value { get; set; } = value;

        public void ApplyDiscount() => State.ApplyDiscount(this);
        public void Approve() => State.Approve(this);
        public void Refuse() => State.Refuse(this);
        public void Complete() => State.Complete(this);
    }
}
