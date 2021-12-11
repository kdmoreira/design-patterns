using System;

namespace DesignPatterns.Example
{
    public class TaxCalculator
    {
        // Even though there are classes responsible for each calculation,
        // there are still too many 'ifs' in this method

        //public void Calculate(Budget budget, string tax)
        //{
        //    if ("ICMS".Equals(tax))
        //    {
        //        double icms = new ICMS().CalculateICMS(budget);
        //        Console.WriteLine(icms);
        //    }
        //    else if ("ISS".Equals(tax))
        //    {
        //        double iss = new ISS().CalculateISS(budget);
        //        Console.WriteLine(iss);
        //    }
        //}

        // A little better, but there's a problem: if a new developer
        // needs to create a new class for a new tax, will they remember
        // to create another method here?

        //public void CalculateICMS(Budget budget)
        //{
        //    double icms = new ICMS().CalculateICMS(budget);
        //    Console.WriteLine(icms);
        //}

        //public void CalculateISS(Budget budget)
        //{
        //    double iss = new ISS().CalculateISS(budget);
        //    Console.WriteLine(iss);
        //}

        // STRATEGY PATTERN:
        // Only one method, which will receive the strategy (the kind of tax
        // we need to calculate) and the most generic type (in this
        // case, the interface Tax); this is a type of polymorphism
        // that simplifies the code and its further development
        public void Calculate(Budget budget, Tax tax)
        {
            double value = tax.Calculate(budget);
            Console.WriteLine(value);
        }
    }
}
