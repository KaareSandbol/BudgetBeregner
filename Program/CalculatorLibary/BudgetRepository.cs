using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibary
{
    public class BudgetRepository
    {
        public int CalculatorDisposable(List<int> IncomeList, List<int> ExpensesList)
        {
            int incomeSum = IncomeList.Sum();
            int expensesSum = ExpensesList.Sum();
            return incomeSum - expensesSum;
        }
    }
}
