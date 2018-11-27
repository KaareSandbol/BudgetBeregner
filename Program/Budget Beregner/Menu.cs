using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Beregner
{
    public class Menu
    {
        Controller control = new Controller();

        public void Show()
        {
            bool running = true;
            do
            {
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
                        CreateBudgetSimple();
                        break;
                    case "3":
                        CreateBudgetAdvanced();
                        break;
                    case "4":
                        CreateBudgetPersonal();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadLine();
                        break;
                }
            } while (running);
        }
        // TODO: Additional menu with diffecent budget types for choice
        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("--== Velkommen til AL budget beregner! ==--");
            Console.WriteLine("Vælg venligst en" +
                " af nedenstående menupunkter...");
            Console.WriteLine();
            Console.WriteLine("1. Vis budget - NA");
            Console.WriteLine("2. Lav simpelt budget - NA");
            Console.WriteLine("3. Lav avanceret budget - NA");
            Console.WriteLine("4. Lav eget budget - NA");
            Console.WriteLine("0. Exit");
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
            Console.WriteLine("IKKE IMPLEMENTERET ENDNU...");
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
