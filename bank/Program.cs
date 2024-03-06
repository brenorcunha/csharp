using System;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the application type number you will use:");
            Console.WriteLine("1 - Savings (Can be withdrawn at any time) – 0.78% per month");
            Console.WriteLine("2 - Capitalization Bond (Can be withdrawn after 24 months) – 0.97% per month");
            Console.WriteLine("3 - CDB (Can be withdrawn after 6 months) – 0.78% per month");
            Console.WriteLine("4 - CDB (Can be withdrawn between 6 and 12 months) – 0.85% per month");
            Console.WriteLine("5 - RDB (Can withdraw half of the amount after 6 months and after 12 months) – 0.90% per month");

            short op1 = Convert.ToInt16(Console.ReadLine());
            ABCBank.Application = op1;

            Console.WriteLine("Enter the initial investment amount:");
            short op2 = Convert.ToInt16(Console.ReadLine());
            ABCBank.InitialValue = op2;

            Console.WriteLine("Enter the monthly investment amount:");
            double op3 = Convert.ToDouble(Console.ReadLine());
            ABCBank.MensalValue = op3;

            Console.WriteLine("Enter the investment period (in months):");
            short op4 = Convert.ToInt16(Console.ReadLine());
            ABCBank.TimePeriod = op4;

            ABCBank abc = new ABCBank();
            Console.WriteLine("Amount to be redeemed = "+ abc.A2BReed(ABCBank.Application, ABCBank.InitialValue, ABCBank.MensalValue, ABCBank.TimePeriod));

            NaturalPerson np = new NaturalPerson();
            np.Name = "Breno";
            np.CalculateFare(100);
            Console.WriteLine("Calculate Fare NP: "+ np.CalculateFare(100));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
