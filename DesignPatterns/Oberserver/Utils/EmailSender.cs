using Oberserver.Abstractions;
using Observer.Models;

namespace Oberserver.Utils
{
    public class EmailSender : IInvoiceAction
    {
        public void Execute(Invoice invoice)
        {
            Console.WriteLine($"Invoice {invoice.Name} sent by e-mail.");
        }
    }
}
