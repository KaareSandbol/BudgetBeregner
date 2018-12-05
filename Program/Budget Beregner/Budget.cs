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
        int row = 0;
        int column = 0;
        int columnamount = 0;
        bool exit = true;
        
        

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

        internal void CreateBudgetAdvanced()
        {
            row = 30;
            column = 2;
            columnamount = 22;

            Console.Clear();
            Console.WriteLine("Budget til 18-25 årige der bor ude");
            Console.WriteLine("Indtast indkomster:");
            Console.WriteLine("SU: ");
            Console.WriteLine("Løn: ");
            Console.WriteLine("Boligstøtte: ");
            Console.WriteLine("Stipendier: ");
            Console.WriteLine("\nIndtast Udgifter:");
            Console.WriteLine("Forsikring: ");
            Console.WriteLine("Husleje: ");
            Console.WriteLine("Aconto: ");
            Console.WriteLine("El: ");
            Console.WriteLine("A-kasse: ");
            Console.WriteLine("Mad: ");
            Console.WriteLine("Personlig pleje: ");
            Console.WriteLine("Rengøring: ");
            Console.WriteLine("Tandlæge: ");
            Console.WriteLine("Mobil: ");
            Console.WriteLine("Transport: ");
            Console.WriteLine("Skole: ");
            Console.WriteLine("Internet/licens: ");
            Console.WriteLine("Fitness og sport: ");
            Console.WriteLine("Streaming tjenester: ");
            Console.WriteLine("Bil: ");
            Console.WriteLine("Lån: ");
            Console.WriteLine("Opsparing: ");



            for (int i = 0; i < columnamount; i++)
            {
                if (i < 4)
                {
                    InputIncome();
                }

                if (i == 4)
                {
                    column += 2;
                }

                if (i >= 4)
                {
                    InputExpense();
                }

                exit = true;
            }

            BudgetRepository budgetRepo = new BudgetRepository();
            Console.WriteLine("\nDit rådighedsbeløb er: " + budgetRepo.CalculatorDisposable(Income, Expenses));
            Income.Clear();
            Expenses.Clear();
            Console.ReadKey();
        }

        public void CreateBudgetSimple()
        {
            row = 20;
            column = 2;
            columnamount = 6;

            Console.Clear();
            Console.WriteLine("Budget til 18-25 årige der bor hjemme");
            Console.WriteLine("Indtast indkomster:");
            Console.WriteLine("SU: ");
            Console.WriteLine("Løn: ");
            Console.WriteLine("\nIndtast Udgifter:");
            Console.WriteLine("Mobil: ");
            Console.WriteLine("Husleje: ");
            Console.WriteLine("Personlig pleje: ");
            Console.WriteLine("Opsparing: ");

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
            Console.WriteLine("\nDit rådighedsbeløb er: " + budgetRepo.CalculatorDisposable(Income, Expenses));
            Income.Clear();
            Expenses.Clear();
            Console.ReadKey();
        }
    }
}
