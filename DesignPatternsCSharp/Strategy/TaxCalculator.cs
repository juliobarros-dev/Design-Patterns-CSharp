namespace Strategy
{
    internal class TaxCalculator
    {
        public static void Calculate(Budget budget, string taxType)
        {
            // Heres is a bad example because everytime we need to add a new Tax we would need to edit the calculator adding more ifs and logic here.
            // This would increase the complexity dificulting the maintance of the code.

            if ("ICMS".Equals(taxType))
            {
                double icms = budget.Value * 0.1;
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(taxType))
            {
                double iss = budget.Value * 0.06;
                Console.WriteLine(iss);
            }
        }
    }
}
