using System;

namespace Labb2_BankLoan
{
    class MainClass
    {

        

        public static void Main(string[] args)
        {
            int years, loanAmount;
            double totalAmount;

            Console.WriteLine("Hej och välkommen till banken!");
            Console.Write("\nÖnskat lånebelopp (kr): ");
            loanAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("\nRäntesatser:\n1 år: 3%\n2 år: 4%\n3 år: 5%\n4 år: 6%\n5 år: 7%\n6 år: 8%\n7 år: 9%\n8 år: 10%\n9 år: 11%\n10 år: 12%");
            Console.Write("\nÖnskad återbetalningstid (1-10 år): ");
            years = int.Parse(Console.ReadLine());

            
        }
    }
}
