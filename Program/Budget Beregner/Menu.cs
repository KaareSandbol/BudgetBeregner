using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetLibrary;

namespace Budget_Beregner
{
    public class Menu
    {
        bool running = true;

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
            Template budget = new Template();
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
                        budget.TemplateSimple();
                        break;
                    case "2":
                        budget.TemplateAdvanced();
                        break;
                    case "3":
                        budget.TemplatePersonal();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadKey();
                        break;
                }
            } while (menuType);
        }
        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("--== Velkommen til AL budget beregner! ==--");
            Console.WriteLine("Vælg venligst en af nedenstående menupunkter...");
            Console.WriteLine();
            Console.WriteLine("1. Vis budget");
            Console.WriteLine("2. Lav et budget");
            Console.WriteLine("0. Exit");
        }
        private void ShowBudgetMenu()
        {
            Console.Clear();
            Console.WriteLine("--== Vælg hvilket budget du vil lægge ==--");
            Console.WriteLine();
            Console.WriteLine("1. Lav simpelt budget");
            Console.WriteLine("2. Lav avanceret budget");
            Console.WriteLine("3. Lav eget budget");
            Console.WriteLine("0. Gå tilbage til forrige menu");
        }

        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }
        private void ShowBudget()
        {
            Console.Clear();
            BudgetRepository budgetRepo = new BudgetRepository();
            Console.WriteLine("Skriv navnet på det budget du vil hente: (Skal være et der er gemt gennem dette program)");
            string path = Console.ReadLine();
            budgetRepo.LoadBudget(path);
            Console.ReadKey();
        }
    }
}
