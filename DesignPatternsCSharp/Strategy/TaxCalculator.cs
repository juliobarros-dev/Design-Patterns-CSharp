using Strategy.Models;
using Strategy.Models.Taxes;

namespace Strategy
{
    internal class TaxCalculator
    {
        public void Calculate(Budget budget, string taxType)
        {
            // At this points we isolate the responsability to calculate the tax to the respective tribute
            // But we still didn't solve the problema because there are still ifs they tend to increase if we need to add more taxes in the future.

            if ("ICMS".Equals(taxType))
            {
                double icms = new Icms().Calculate(budget);
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(taxType))
            {
                double iss = new Iss().Calculate(budget);
                Console.WriteLine(iss);
            }
        }
    }
}
