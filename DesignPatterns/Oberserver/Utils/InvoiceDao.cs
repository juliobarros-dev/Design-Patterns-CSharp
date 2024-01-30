using Oberserver.Abstractions;
using Observer.Models;

namespace Oberserver.Utils
{
    public class InvoiceDao : IInvoiceAction
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine($"{invoice.Name} saved.");
        }
    }
}
