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
    public class CategoryServices : ICategoryServices
    {
        private dbModelContext _context;

        public OperationResult<IEnumerable<Category>> FindBy(Expression<Func<Category, bool>> condition)
        {
            try
            {
                IEnumerable<Category> result;

                using (_context = new dbModelContext())
                {
                    result = _context.Categories.Where(condition).ToList();
                }

                return OperationResult<IEnumerable<Category>>.SetSucces(result);
            }
            catch (Exception ex)
            {
                return OperationResult<IEnumerable<Category>>.SetFail(ex.Message);
            }
        }

        public OperationResult<IEnumerable<Category>> GetAll()
        {
            try
            {
                IEnumerable<Category> result;

                using (_context = new dbModelContext())
                {
                    result = _context.Categories.Select(c => c).ToList();
                }

                return OperationResult<IEnumerable<Category>>.SetSucces(result);
            }
            catch (Exception ex)
            {
                return OperationResult<IEnumerable<Category>>.SetFail(ex.Message);
            }
        }

        public OperationResult Create(Category entity)
        {
            try
            {
                using (_context = new dbModelContext())
                {
                    _context.Categories.Add(entity);
                    _context.SaveChanges();
                }

                return OperationResult.SetSucces();
            }
            catch (Exception ex)
            {
                return OperationResult.SetFail(ex.Message);
            }
        }

        public OperationResult Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
