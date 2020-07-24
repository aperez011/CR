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
    public class CashExpenseServices : ICashExpenseServices
    {
        private dbModelContext _context;

        public CashExpenseServices()
        {

        }

        public OperationResult<IEnumerable<CashExpense>> FindBy(Expression<Func<CashExpense, bool>> condition)
        {
            try
            {
                IEnumerable<CashExpense> result;

                using (_context = new dbModelContext())
                {
                    result = _context.CashExpenses.Where(condition).ToList();
                }

                return OperationResult<IEnumerable<CashExpense>>.SetSucces(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public OperationResult<IEnumerable<CashExpense>> GetAll()
        {
            try
            {
                IEnumerable<CashExpense> result;

                using (_context = new dbModelContext())
                {
                    result = _context.CashExpenses.Select(c => c).ToList();
                }

                return OperationResult<IEnumerable<CashExpense>>.SetSucces(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public OperationResult Create(CashExpense entity)
        {
            try
            {

                using (_context = new dbModelContext())
                {
                    _context.CashExpenses.Add(entity);
                    _context.SaveChanges();
                }

                return OperationResult.SetSucces();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OperationResult Update(CashExpense entity)
        {
            try
            {
                //using (_context = new dbModelContext())
                //{
                //    _context.CashExpenses.Add(entity);
                //    _context.SaveChanges();
                //}

                return OperationResult.SetSucces();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
