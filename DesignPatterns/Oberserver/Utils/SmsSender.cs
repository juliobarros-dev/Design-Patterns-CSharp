using Oberserver.Abstractions;
using Observer.Models;

namespace Oberserver.Utils
{
    public class SmsSender : IInvoiceAction
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine($"Invoice {invoice.Name} sent by SMS.");
        }
    }
}
