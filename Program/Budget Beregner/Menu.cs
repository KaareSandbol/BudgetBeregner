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
            Console.WriteLine("Vælg venligst en af nedenstående menupunkter:\n");
            Console.WriteLine("1. Vis budget.\n");
            Console.WriteLine("2. Lav et budget.\n");
            Console.WriteLine("0. Exit.\n");
        }
        private void ShowBudgetMenu()
        {
            Console.Clear();
            Console.WriteLine("--== Vælg hvilket budget du vil lægge ==--");
            Console.WriteLine();
            Console.WriteLine("1. Lav simpelt budget - Simpelt budget som er målrettet mod den hjemmeboende studerende i alderen 18-25.\n");
            Console.WriteLine("2. Lav advanceret budget - Advanceret budget som er målrettet mod den udeboende studerende i alderen 18-25.\n");
            Console.WriteLine("3. Lav eget budget - Lav personligt budget med egne indkomster og udgifter.\n");
            Console.WriteLine("0. Gå tilbage til forrige menu.\n");
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
            Console.Write("Skriv navnet på det budget du vil hente: ");
            string path = Console.ReadLine();
            budgetRepo.LoadBudget(path);
            Console.ReadKey();
        }
    }
}
