using CR.Data;
using CR.Entities;
using CR.Utilities;
using CR.Utilities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CR.Services
{
    public class ExpenseTypeServices : ICategoryServices
    {
        private dbModelContext _context;

        public OperationResult<IEnumerable<ExpenseType>> FindBy(Expression<Func<ExpenseType, bool>> condition)
        {
            try
            {
                IEnumerable<ExpenseType> result;

                using (_context = new dbModelContext())
                {
                    result = _context.ExpenseTypes.Where(condition).ToList();
                }

                return OperationResult<IEnumerable<ExpenseType>>.SetSucces(result);
            }
            catch (Exception ex)
            {
                return OperationResult<IEnumerable<ExpenseType>>.SetFail(ex.Message);
            }
        }

        public OperationResult<IEnumerable<ExpenseType>> GetAll()
        {
            try
            {
                IEnumerable<ExpenseType> result;

                using (_context = new dbModelContext())
                {
                    result = _context.ExpenseTypes.Select(c => c).ToList();
                }

                return OperationResult<IEnumerable<ExpenseType>>.SetSucces(result);
            }
            catch (Exception ex)
            {
                return OperationResult<IEnumerable<ExpenseType>>.SetFail(ex.Message);
            }
        }

        public OperationResult Create(ExpenseType entity)
        {
            try
            {
                using (_context = new dbModelContext())
                {
                    _context.ExpenseTypes.Add(entity);
                    _context.SaveChanges();
                }

                return OperationResult.SetSucces();
            }
            catch (Exception ex)
            {
                return OperationResult.SetFail(ex.Message);
            }
        }

        public OperationResult Update(ExpenseType entity)
        {
            throw new NotImplementedException();
        }
    }
}
