using CR.Data;
using CR.Entities;
using CR.Utilities;
using CR.Utilities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CR.Services
{
    public class CoinServices : ICoinServices
    {
        public static dbModelContext _context;

        public OperationResult<IEnumerable<Coin>> FindBy(Expression<Func<Coin, bool>> condition)
        {
            try
            {
                IEnumerable<Coin> result;

                using (_context = new dbModelContext())
                {
                    result = _context.Coins.Where(condition).ToList();
                }

                return OperationResult<IEnumerable<Coin>>.SetSucces(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public OperationResult<IEnumerable<Coin>> GetAll()
        {
            try
            {
                IEnumerable<Coin> result;

                using (_context = new dbModelContext())
                {
                    result = _context.Coins.Select(c=>c).ToList();
                }

                return OperationResult<IEnumerable<Coin>>.SetSucces(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public OperationResult Create(Coin entity)
        {
            try
            {
                using (_context = new dbModelContext())
                {
                    _context.Coins.Add(entity);

                    _context.SaveChanges();
                }

                return OperationResult.SetSucces();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public OperationResult Update(Coin entity)
        {
            try
            {
                using (_context = new dbModelContext())
                {
                    var coin = _context.Coins.FirstOrDefault(c => c.Id == entity.Id);

                    coin.Name = entity.Name;
                    coin.Description = entity.Description;
                    coin.Type = entity.Type;

                    _context.SaveChanges();
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
