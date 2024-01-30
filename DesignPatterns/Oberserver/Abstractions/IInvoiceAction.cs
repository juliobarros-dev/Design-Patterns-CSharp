using Observer.Models;

namespace Oberserver.Abstractions
{
    public interface IInvoiceAction
    {
        public void Execute(Invoice invoice);
    }
}
