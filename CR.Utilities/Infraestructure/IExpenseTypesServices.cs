using CR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Utilities.Infraestructure
{
    public interface IExpenseTypesServices : IBaseMethods<ExpenseType>
    {
        OperationResult Delete(int entityId);
    }
}
