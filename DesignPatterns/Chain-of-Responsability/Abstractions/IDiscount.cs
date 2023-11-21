using Chain_of_Responsability.Models;

namespace Chain_of_Responsability.Abstractions
{
    internal interface IDiscount
    {
        IDiscount? Next { get; set; }
        double Discount(Order order);
    }
}
