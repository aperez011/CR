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
    public class CashRegisterServices : ICashRegisterServices
    {
        public static dbModelContext _context;

        public CashRegisterServices()
        {

        }

        public OperationResult<IEnumerable<CashRegister>> FindBy(Expression<Func<CashRegister, bool>> condition)
        {
            try
            {
                IEnumerable<CashRegister> result;

                using (_context = new dbModelContext())
                {
                    result = _context.CashRegisters.Where(condition).ToList();
                }

                return OperationResult<IEnumerable<CashRegister>>.SetSucces(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OperationResult<IEnumerable<CashRegister>> GetAll()
        {
            try
            {
                IEnumerable<CashRegister> result;

                using (_context = new dbModelContext())
                {
                    result = _context.CashRegisters.Select(c=>c).ToList();
                }

                return OperationResult<IEnumerable<CashRegister>>.SetSucces(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OperationResult Create(CashRegister entity)
        {
            try
            {
                using (_context = new dbModelContext())
                {
                    _context.CashRegisters.Add(entity);
                    _context.SaveChanges();
                }

                return OperationResult.SetSucces();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public OperationResult Update(CashRegister entity)
        {
            try
            {
                using (_context = new dbModelContext())
                {
                    //_context.CashRegisters.Add(entity);
                    //_context.SaveChanges();
                }

                return OperationResult.SetSucces();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
