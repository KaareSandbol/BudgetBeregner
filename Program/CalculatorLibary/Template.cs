using BudgetLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Beregner
{
    public class Template
    {
        List<string> incomeColumn = new List<string>();
        List<string> expenseColumn = new List<string>();
        List<int> Income = new List<int>();
        List<int> Expenses = new List<int>();
        int row = 0;
        int column = 0;
        int columnAmount = 0;
        int incomeNumber = 0;
        int expenseNumber = 0;

        public void PrintIncomeAndExpense()
        {
            for (int i = 0; i < incomeColumn.Count; i++)
            {
                Console.WriteLine(incomeColumn[i]);
            }
            Console.WriteLine("\nIndtast Udgifter:");

            for (int i = 0; i < expenseColumn.Count; i++)
            {
                Console.WriteLine(expenseColumn[i]);
            }
        }
        public void CalculateAndSaveBudget()
        {
            BudgetRepository budgetRepo = new BudgetRepository();
            Console.WriteLine("\nDit rådighedsbeløb er: " + budgetRepo.CalculateDisposableIncome(Income, Expenses));
            Console.WriteLine("Vil du gemme dit budget? Y/N");
            string save = Console.ReadLine();
            if (save is "y" || save is "Y")
            {
                budgetRepo.SaveBudget(incomeColumn, expenseColumn, Income, Expenses);
                Console.ReadKey();
            }
            else if (save is "n" || save is "N")
            {
                Console.WriteLine("Tryk på en knap for at komme tilbage til menuen!");
            }
            incomeColumn.Clear();
            expenseColumn.Clear();
            Income.Clear();
            Expenses.Clear();
            Console.ReadKey();
            columnAmount = 0;
        }
        public void TemplateAdvanced()
        {
            row = 30;
            column = 2;
            incomeColumn.Add("SU: ");
            incomeColumn.Add("Løn: ");
            incomeColumn.Add("Boligstøtte: ");
            incomeColumn.Add("Stipendier: ");

            expenseColumn.Add("Forsikring: ");
            expenseColumn.Add("Husleje: ");
            expenseColumn.Add("Aconto: ");
            expenseColumn.Add("El: ");
            expenseColumn.Add("A-kasse: ");
            expenseColumn.Add("Mad: ");
            expenseColumn.Add("Mobil: ");
            expenseColumn.Add("Transport: ");
            expenseColumn.Add("Internet/lincens: ");
            expenseColumn.Add("Fitness og sport: ");
            expenseColumn.Add("Streaming tjenester: ");
            expenseColumn.Add("Opsparing: ");
            columnAmount = (incomeColumn.Count + expenseColumn.Count);
            Console.Clear();
            Console.WriteLine("Budget til 18-25 årige der bor ude");
            Console.WriteLine("Indtast indkomster:");

            PrintIncomeAndExpense();
            InputIncome();
            column += 2;
            InputExpense();
            CalculateAndSaveBudget();
        }

        public void TemplateSimple()
        {
            row = 30;
            column = 2;
            incomeColumn.Add("SU: ");
            incomeColumn.Add("Løn: ");

            expenseColumn.Add("Mobil: ");
            expenseColumn.Add("Husleje: ");
            expenseColumn.Add("Streaming tjenester: ");
            expenseColumn.Add("Opsparing: ");
            columnAmount = (incomeColumn.Count + expenseColumn.Count);
            Console.Clear();
            Console.WriteLine("Budget til 18-25 årige der bor hjemme");
            Console.WriteLine("Indtast indkomster:");

            PrintIncomeAndExpense();
            InputIncome();
            column += 2;
            InputExpense();
            CalculateAndSaveBudget();
        }

        public void TemplatePersonal()
        {
            bool looping = true;
            bool exit = true;
            column = 2;

            Console.Clear();
            Console.WriteLine("Velkommen til dit eget personlige budget!");
            Console.WriteLine("Indtast indkomster, navn og værdi, og afslut med 'ENTER':");

            while (exit)
            {
                looping = true;
                row = 0;
                Console.SetCursorPosition(row, column);
                string input = Console.ReadLine();

                // Exits out of income input
                if (input.Equals(string.Empty))
                {
                    exit = false;
                    column += 2;
                }

                else if (input is string)
                {
                    incomeColumn.Add(input + ":");
                    row = 30;

                    while (looping)
                    {
                        Console.SetCursorPosition(row, column);
                        input = Console.ReadLine();

                        if (int.TryParse(input, out incomeNumber))
                        {
                            Income.Add(incomeNumber);
                            column += 1;
                            looping = false;
                        }

                        else
                        {
                            Console.SetCursorPosition(row + 10, column);
                            Console.WriteLine("Indtast venligst et tal. ");
                            Console.SetCursorPosition(row + 35, column);
                            Console.ReadKey();
                            Console.SetCursorPosition(row + 10, column);
                            Console.Write("                                    ");
                            Console.SetCursorPosition(row, column);
                            Console.Write("                   ");
                            Console.SetCursorPosition(row, column);
                        }
                    }
                }
            }

            looping = true;
            exit = true;
            Console.WriteLine("Indtast udgifter, navn og værdi, og afslut med 'ENTER':");

            while (exit)
            {
                looping = true;
                row = 0;
                Console.SetCursorPosition(row, column);
                string input = Console.ReadLine();

                if (input.Equals(string.Empty))
                {
                    exit = false;
                }

                else if (input is string)
                {
                    expenseColumn.Add(input + ":");
                    row = 30;

                    while (looping)
                    {
                        Console.SetCursorPosition(row, column);
                        input = Console.ReadLine();

                        if (int.TryParse(input, out expenseNumber))
                        {
                            Expenses.Add(expenseNumber);
                            column += 1;
                            looping = false;
                        }

                        else
                        {
                            Console.SetCursorPosition(row + 10, column);
                            Console.WriteLine("Indtast venligst et tal.");
                            Console.SetCursorPosition(row + 35, column);
                            Console.ReadKey();
                            Console.SetCursorPosition(row + 10, column);
                            Console.Write("                                    ");
                            Console.SetCursorPosition(row, column);
                            Console.Write("                   ");
                            Console.SetCursorPosition(row, column);
                        }
                    }
                }
            }

            CalculateAndSaveBudget();
        }

        private void InputIncome()
        {
            for (int i = 0; i < incomeColumn.Count;)
            {
                Console.SetCursorPosition(row, column);
                string input = Console.ReadLine();

                if (int.TryParse(input, out incomeNumber))
                {
                    Income.Add(incomeNumber);
                    column += 1;
                    i++;
                }

                else
                {
                    Console.SetCursorPosition(row + 10, column);
                    Console.WriteLine("Indtast venligst et tal. ");
                    Console.SetCursorPosition(row + 35, column);
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
            for (int i = 0; i < expenseColumn.Count;)
            {
                Console.SetCursorPosition(row, column);
                string input = Console.ReadLine();

                if (int.TryParse(input, out expenseNumber))
                {
                    Expenses.Add(expenseNumber);
                    column += 1;
                    i++;
                }

                else
                {
                    Console.SetCursorPosition(row + 10, column);
                    Console.WriteLine("Indtast venligst et tal.");
                    Console.SetCursorPosition(row + 35, column);
                    Console.ReadKey();
                    Console.SetCursorPosition(row + 10, column);
                    Console.Write("                                    ");
                    Console.SetCursorPosition(row, column);
                    Console.Write("                   ");
                    Console.SetCursorPosition(row, column);
                }
            }
        }
    }
}
