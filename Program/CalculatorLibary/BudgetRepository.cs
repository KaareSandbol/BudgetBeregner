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
        public int CalculatorDisposable(List<int> IncomeList, List<int> ExpensesList)
        {
            int incomeSum = IncomeList.Sum();
            int expensesSum = ExpensesList.Sum();
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
                    sw.WriteLine(incomeColumn[i]+" "+incomeList[i]);
                }
                sw.WriteLine();
                sw.WriteLine("Udgifter");
                for (int i = 0; i < expenseColumn.Count; i++)
                {
                    sw.WriteLine(expenseColumn[i]+" "+expensesList[i]);
                }
                sw.WriteLine("\nRådighedsbeløb: "+CalculatorDisposable(incomeList, expensesList));
            }

            Console.WriteLine("\nDit budget er blevet gemt.");
                
        }

        public void LoadBudget(string path)
        {
            string line;
            // TODO: Add en exception for hvis man ikke vælger en gyldig fil
            using (StreamReader sr = new StreamReader(path))
            {
                Console.Clear();
                Console.WriteLine("Budget: ");
                Console.WriteLine("");
                
                while ((line = sr.ReadLine()) != null)
                {
                  Console.WriteLine(line);
                }
 

            }
        }
    }
}
