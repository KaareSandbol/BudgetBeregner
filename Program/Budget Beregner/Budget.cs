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
        // TODO: Need variable to check if it's expense or income.
        int row = 10;
        int column = 2;
        bool exit = true;
        // HACK: Hacked for demo too.
        int columnamount = 4;

        List<int> Income = new List<int>();
        List<int> Expenses = new List<int>();

        private void InputIncome()
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
                    Console.SetCursorPosition(row + 10, column);
                    Console.WriteLine("Indtast venligst et tal.");
                    Console.ReadKey();
                    Console.SetCursorPosition(row + 10, column);
                    Console.Write("                                    ");
                    Console.SetCursorPosition(row, column);
                    Console.Write("                   ");
                    Console.SetCursorPosition(row, column);
                }
            }
        }

        private void InputExpense()
        {
            while (exit)
            {
                try
                {
                    Console.SetCursorPosition(row, column);
                    Expenses.Add(int.Parse(Console.ReadLine()));
                    column += 1;
                    exit = false;
                }

                catch (Exception)
                {
                    Console.SetCursorPosition(row + 10, column);
                    Console.WriteLine("Indtast venligst et tal.");
                    Console.ReadKey();
                    Console.SetCursorPosition(row + 10, column);
                    Console.Write("                                    ");
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

            // HACK: Only works if there's exactly 2 types of income. Hacked for demo purposes.
            for (int i = 0; i < columnamount; i++)
            {
                if (i < 2)
                {
                    InputIncome();
                }
              
                if (i == 2)
                {
                    column += 2;
                }

                if (i >= 2)
                {
                    InputExpense();
                }

                exit = true;
            }
          
            BudgetRepository budgetRepo = new BudgetRepository();
            Console.WriteLine("Dit rådighedsbeløb er: " + budgetRepo.CalculatorDisposable(Income, Expenses));
            Console.ReadKey();
        }
    }
}
