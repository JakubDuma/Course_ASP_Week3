using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_ASP_Week3.Data.Models
{
    public class BudgetOperations
    {
        public int Id { get; set; }
        public string Operation { get; set; }

        public BudgetOperations(int id, string operation)
        {
            Id = id;
            Operation = operation;
        }
    }
}
