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
                    result = _context.CashRegisters.Select(c => c).ToList();
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

        public int GetNumberToOpenTurn()
        {
            try
            {
                int turnNumber = 0;

                using (_context = new dbModelContext())
                {
                    var shifts = _context.CashRegisters.Select(c => c.ShiftId);

                    if (shifts.Any())
                    {
                        turnNumber = shifts.Max() + 1;
                    }
                    else
                    {
                        turnNumber = 1;
                    }
                }

                return turnNumber;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int GetNumberToCloseTurn(int userId)
        {
            try
            {
                int turnNumber;

                var turns = this.FindBy(c => c.CashierId == userId);

                if (!turns.Success) throw new Exception();

                var data = turns.Data.ToList();

                turnNumber = data.GroupBy(g => g.ShiftId)
                                  .Select(c => new { key = c.Key, cnt = c.Count() })
                                  .Where(v => v.cnt <= 1).FirstOrDefault().key;

                return turnNumber;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ValidateOpenTurn(int userId)
        {
            try
            {
                bool openTurn = false;

                var turns = this.FindBy(c => c.CashierId == userId);

                if (!turns.Success) throw new Exception();

                var data = turns.Data.ToList();

                var result = data.GroupBy(g => g.ShiftId)
                                   .Select(c => new { key = c.Key, cnt = c.Count() })
                                   .Where(v => v.cnt <= 1);

                openTurn = result.Any();

                return openTurn;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
