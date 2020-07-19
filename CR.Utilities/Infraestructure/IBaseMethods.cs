using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CR.Utilities.Infraestructure
{
    public interface IBaseMethods<T> where T : class, new()
    {
        OperationResult<IEnumerable<T>> GetAll();
        OperationResult<IEnumerable<T>> FindBy(Expression<Func<T, bool>> condition);
        OperationResult Create(T entity);
        OperationResult Update(T entity);
    }
}
