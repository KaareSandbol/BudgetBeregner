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
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadLine();
                        break;
                }
            } while (running);
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Velkommen til AL budget beregner!");
            Console.WriteLine("Vælg venligst en" +
                " af nedenstående menupunkter...");
            Console.WriteLine();
            Console.WriteLine("1. VALG 1");
            Console.WriteLine("2. VALG 2");
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
            throw new NotImplementedException();
        }
        // TODO: Implement CreateBudgetSimple()
        private void CreateBudgetSimple()
        {
            throw new NotImplementedException();
        }
        // TODO: Implement CreateBudgetAdvanced()
        private void CreateBudgetAdvanced()
        {
            throw new NotImplementedException();
        }
        // TODO: Implement CreateBudgetPersonal()
        private void CreateBudgetPersonal()
        {
            throw new NotImplementedException();
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
