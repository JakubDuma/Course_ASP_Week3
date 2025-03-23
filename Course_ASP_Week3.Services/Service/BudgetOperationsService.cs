using Course_ASP_Week3.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_ASP_Week3.Services.Service
{
    public class BudgetOperationsService
    {
        private List<BudgetOperations> Operations = new List<BudgetOperations>();
        public BudgetOperationsService() 
        {
            OperationsInit();
        }

        public void AddOperations(int id, string operation)
        {
            BudgetOperations budgetOperations = new BudgetOperations(id, operation);
            Operations.Add(budgetOperations);
        }

        public void DisplayOperations()
        {
            foreach (var operation in Operations)
            {
                Console.WriteLine($"{operation.Id}. {operation.Operation}");
            }
        }
        private void OperationsInit()
        {
            AddOperations(1, "Add expense");
            AddOperations(2, "Add income");
            AddOperations(3, "Edit entry");
            AddOperations(4, "Delete entry");
            AddOperations(5, "Display current budget");
            AddOperations(6, "List all expenses and incomes");
        }
    }
}
