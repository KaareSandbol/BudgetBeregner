using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BudgetLibrary
{
    public class BudgetRepository
    {
        public int CalculateDisposableIncome(List<int> incomeList, List<int> expensesList)
        {
            int incomeSum = incomeList.Sum();
            int expensesSum = expensesList.Sum();
            return incomeSum - expensesSum;
        }

        public void SaveBudget(List<string> incomeColumn, List<string> expenseColumn, List<int> incomeList, List<int> expensesList)
        {
            Console.Write("Skriv et navn til dit budget: ");
            string name = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(name))
            {
                sw.WriteLine("Indtægter");
                for (int i = 0; i < incomeColumn.Count; i++)
                {
                    if (incomeList[i] != 0)
                    {
                        sw.WriteLine(incomeColumn[i] + " " + incomeList[i]);
                    }                    
                }
                sw.WriteLine();
                sw.WriteLine("Udgifter");
                for (int i = 0; i < expenseColumn.Count; i++)
                {
                    if (expensesList[i] != 0)
                    {
                        sw.WriteLine(expenseColumn[i] + " " + expensesList[i]);
                    }                    
                }
                sw.WriteLine("\nRådighedsbeløb: "+CalculateDisposableIncome(incomeList, expensesList));
            }

            Console.WriteLine("\nDit budget er blevet gemt.");
                
        }

        public void LoadBudget(string path)
        {
            string line;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.Clear();
                    Console.WriteLine("Budget: ");
                    Console.WriteLine("");
                    //TODO: Don't print row that has a value of 0.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            catch (Exception)
            {
                Console.WriteLine("\nUgyldigt budgetnavn.");
            }
        }
    }
}
