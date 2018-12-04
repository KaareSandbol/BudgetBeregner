using CalculatorLibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Beregner
{
    class Budget
    {
        int row = 10;
        int column = 2;
        bool exit = true;
        int columnamount = 4;

        List<int> Income = new List<int>();
        List<int> Expenses = new List<int>();

        private void Input()
        {
            while (exit)
            {
                try
                {
                    Console.SetCursorPosition(row, column);
                    Income.Add(int.Parse(Console.ReadLine()));
                    column += 1;
                    exit = false;
                }
                catch (Exception)
                {
                    Console.SetCursorPosition(0, column + 8);
                    Console.WriteLine("Indtast venligst et tal.");
                    Console.ReadKey();
                    Console.SetCursorPosition(0, column + 8);
                    Console.Write(new string(' ', Console.LargestWindowWidth));
                    Console.SetCursorPosition(row, column);
                    Console.Write("                   ");
                    Console.SetCursorPosition(row, column);
                }
            }
        }
        public void CreateBudgetSimple()
        {
            Console.Clear();
            Console.WriteLine("Budget til 18-25 årige");
            Console.WriteLine("Indtast indkomster:");
            Console.WriteLine("SU: ");
            Console.WriteLine("Løn: ");
            Console.WriteLine("\nIndtast Udgifter:");
            Console.WriteLine("Mobil: ");
            Console.WriteLine("Husleje: ");
            // Console.WriteLine("Personlig pleje: ");

            for (int i = 0; i < columnamount; i++)
            {
                Input();
                exit = true;
            }
          
            BudgetRepository budgetRepo = new BudgetRepository();
            Console.WriteLine("Dit rådighedsbeløb er: " + budgetRepo.CalculatorDisposable(Income, Expenses));
            Console.ReadKey();
        }
    }
}
