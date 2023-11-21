using Template_Method.Models;

namespace Template_Method.Abstractions
{
    internal interface ITax
    {
        double Calculate(Order order);
    }
}
