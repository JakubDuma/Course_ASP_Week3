using Course_ASP_Week3.Services.Service;

namespace Course_ASP_Week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BudgetOperationsService service = new BudgetOperationsService();
            BudgetService budgetService = new BudgetService();

            Console.WriteLine("Welcome to the Budget Tracker");
            Console.WriteLine("Provide starting budget:");
            decimal balance = decimal.Parse(Console.ReadLine());
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose operation:");
                service.DisplayOperations();
                var operation = Console.ReadKey();

                switch (operation.KeyChar)
                {
                    case '1':
                        budgetService.ExpenseAction();
                        break;

                    case '2':
                        budgetService.IncomeAction();
                        break;

                    case '3':
                        budgetService.EditAction();
                        break;

                    case '4':
                        budgetService.DeleteAction();
                        break;

                    case '5':
                        budgetService.CurrentBalance(balance);
                        Console.ReadKey();
                        break;

                    case '6':
                        budgetService.AllEntries();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}