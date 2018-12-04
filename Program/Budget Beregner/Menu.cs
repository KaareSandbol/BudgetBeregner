using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibary;

namespace Budget_Beregner
{
    public class Menu
    {
        bool running = true;
        Controller control = new Controller();

        public void StartMenu()
        {
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;                
                ShowMenu();
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "0":
                        running = false;
                        break;
                    case "1":
                        ShowBudget();
                        break;
                    case "2":
                        BudgetMenu();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");                        
                        Console.ReadKey();
                        break;
                }
            } while (running);
        }

        public void BudgetMenu()
        {
            bool menuType = true;
            do
            {
                ShowBudgetMenu();
                string choice = GetUserChoice();
                switch (choice)
                {
                    case "0":
                        ShowMenu();
                        menuType = false;
                        break;
                    case "1":
                        CreateBudgetSimple();
                        break;
                    case "2":
                        CreateBudgetAdvanced();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadKey();
                        break;
                }
            } while (menuType);
        }
        // TODO: Additional menu with diffecent budget types for choice
        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("--== Velkommen til AL budget beregner! ==--");
            Console.WriteLine("Vælg venligst en af nedenstående menupunkter...");
            Console.WriteLine();
            Console.WriteLine("1. Vis budget - NA");
            Console.WriteLine("2. Lav et budget");
            Console.WriteLine("0. Exit");
        }
        // TODO: Give the ability to choose and run the method
        private void ShowBudgetMenu()
        {
            Console.Clear();
            Console.WriteLine("--== Vælg hvilket budget du vil lægge ==--");
            Console.WriteLine();
            Console.WriteLine("1. Lav simpelt budget");
            Console.WriteLine("2. Lav avanceret budget - NA");
            Console.WriteLine("3. Lav eget budget - NA");
            Console.WriteLine("0. Gå tilbage til forrige menu");
        }

        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }
        // TODO: Implement ShowBudget()
        private void ShowBudget()
        {
            Console.WriteLine("IKKE IMPLEMENTERET ENDNU...");
            Console.ReadKey();
        }
        // TODO: Implement CreateBudgetSimple()
        private void CreateBudgetSimple()
        {
            List<int> Income = new List<int>();
            List<int> Expenses = new List<int>();

            
            Console.Clear();
            Console.WriteLine("Budget til 18-25 årige");
            Console.WriteLine("Indtast indkomster:");
            Console.WriteLine("SU: ");
            Console.WriteLine("Løn: ");
            Console.WriteLine("\nIndtast Udgifter:");
            Console.WriteLine("Mobil: ");
            Console.WriteLine("Husleje: ");

            Console.SetCursorPosition(10, 2);
            try
            {
                Income.Add(int.Parse(Console.ReadLine()));
            }
            catch (Exception)
            {
                Console.SetCursorPosition(0, 10);
                Console.WriteLine("Indtast venligst et tal.");
                Console.ReadKey();
                Console.SetCursorPosition(0, 10);
                Console.Write(new string(' ', Console.LargestWindowWidth));
                Console.SetCursorPosition(10, 0);
                Console.Write(new string(' ', Console.LargestWindowWidth));
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("SU: ");
                Console.SetCursorPosition(10, 2);
            }         
            Console.SetCursorPosition(10, 3);
            Income.Add(int.Parse(Console.ReadLine()));

            Console.SetCursorPosition(10, 6);
            Expenses.Add(int.Parse(Console.ReadLine()));
            Console.SetCursorPosition(10, 7);
            Expenses.Add(int.Parse(Console.ReadLine()));
            BudgetRepository budgetRepo = new BudgetRepository();
            Console.WriteLine("Dit rådighedsbeløb er: "+ budgetRepo.CalculatorDisposable(Income, Expenses));
            Console.ReadKey();
        }
        // TODO: Implement CreateBudgetAdvanced()
        private void CreateBudgetAdvanced()
        {
            Console.WriteLine("IKKE IMPLEMENTERET ENDNU...");
            Console.ReadKey();
        }
        // TODO: Implement CreateBudgetPersonal()
        private void CreateBudgetPersonal()
        {
            Console.WriteLine("IKKE IMPLEMENTERET ENDNU...");
            Console.ReadKey();
        }
        // TODO: Implement SaveBudget()
        private void SaveBudget()
        {
            throw new NotImplementedException();
        }
        // TODO: Implement LoadBudget()
        private void LoadBudget()
        {
            throw new NotImplementedException();
        }
    }
}
