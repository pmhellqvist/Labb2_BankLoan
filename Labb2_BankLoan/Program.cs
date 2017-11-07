using System;

namespace Labb2_BankLoan
{
    class MainClass
    {

        public static double Interest(int loanAmount, int years)
        {
            double totalAmount = 0;

            if (years == 1)
            {
                totalAmount = loanAmount * 1.03;
            }
            else if (years == 2)
            {
                totalAmount = loanAmount * 1.04;
            }
            else if (years == 3)
            {
                totalAmount = loanAmount * 1.05;
            }
            else if (years == 4)
            {
                totalAmount = loanAmount * 1.06;
            }
            else if (years == 5)
            {
                totalAmount = loanAmount * 1.07;
            }
            else if (years == 6)
            {
                totalAmount = loanAmount * 1.08;
            }
            else if (years == 7)
            {
                totalAmount = loanAmount * 1.09;
            }
            else if (years == 8)
            {
                totalAmount = loanAmount * 1.10;
            }
            else if (years == 9)
            {
                totalAmount = loanAmount * 1.11;
            }
            else if (years == 10)
            {
                totalAmount = loanAmount * 1.12;
            }

            return totalAmount;

        }
        public static double MonthlyPayment(double totalAmount, double years)
        {
            double numberOfMonths = years * 12;

            double amortization = totalAmount / numberOfMonths;
            return Math.Round(amortization, 0);

        }

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

            totalAmount = Interest(loanAmount, years);

            Console.WriteLine("\nDitt lån:");
            Console.WriteLine("Din månadskostnad kommer bli: " + MonthlyPayment(totalAmount, years) + " kr");
            Console.WriteLine("Totalt återbetalningsbelopp: " + totalAmount + " kr");
            Console.ReadLine();
        }
    }
}
