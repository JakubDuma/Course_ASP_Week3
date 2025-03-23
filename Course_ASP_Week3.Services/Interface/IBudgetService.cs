using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_ASP_Week3.Services.Interface
{
    public interface IBudgetService
    {
        decimal ExpenseAction();
        decimal IncomeAction();
        void EditAction();
        void DeleteAction();
    }
}
