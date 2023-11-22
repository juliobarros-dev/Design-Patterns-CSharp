namespace State.Models
{
    internal class Order(double value)
    {
        public int PENDING { get; set; } = 1;
        public int APPROVED { get; set; } = 2;
        public int REFUSED { get; set; } = 3;
        public int COMPLETED { get; set; } = 4;
        public int CURRENT_STATE { get; set; }
        internal double Value { get; private set; } = value;

        public void ApplyDiscount()
        {
            // At this point we can already imagine the problem here, whenever we need to add a new state or discount we would need to add more if operators
            if (CURRENT_STATE == PENDING) Value -= (Value * 0.05);
            else if (CURRENT_STATE == APPROVED) Value -= (Value * 0.02);
            else throw new Exception("No more discounts to be applied.");
        }
    }
}
