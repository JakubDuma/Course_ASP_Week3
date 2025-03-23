using Course_ASP_Week3.Data.Helpers;

namespace Course_ASP_Week3.Data.Models
{
    public class BudgetEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public ActionType Type { get; set; }
    }
}
