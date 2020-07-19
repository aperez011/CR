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
    public class LoginServices : ILoginServices
    {
        public static dbModelContext _context;

        public LoginServices()
        {
        }

        public OperationResult<User> Login(string userName, string password)
        {
            try
            {
                User result;

                using (_context = new dbModelContext())
                {
                    result = _context.User.FirstOrDefault(c => c.UserName == userName);

                    if (result == null || result.Password.DencryptText() != password) return OperationResult<User>.SetFail("El usuario ó la contraseña son incorrectos");
                }

                return OperationResult<User>.SetSucces(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public OperationResult<IEnumerable<User>> FindBy(Expression<Func<User, bool>> condition)
        {
            try
            {
                IEnumerable<User> result;

                using (_context = new dbModelContext())
                {
                    result = _context.User.Where(condition).ToList();
                }

                return OperationResult<IEnumerable<User>>.SetSucces(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OperationResult<IEnumerable<User>> GetAll()
        {
            try
            {
                List<User> result;

                using (_context = new dbModelContext())
                {
                    result = _context.User.Select(c => c).ToList();
                }

                return OperationResult<IEnumerable<User>>.SetSucces(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OperationResult Create(User entity)
        {
            try
            {
                var validateUser = this.FindBy(c => c.UserName == entity.UserName);
                if (validateUser.Success && validateUser.Data.Any()) return OperationResult.SetFail($"El usuario {entity.UserName} ya se encuertra registrado.");

                using (_context = new dbModelContext())
                {
                    _context.User.Add(entity);
                    _context.SaveChanges();
                }

                return OperationResult.SetSucces();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public OperationResult Update(User entity)
        {
            try
            {
                using (_context = new dbModelContext())
                {
                    var user = _context.User.FirstOrDefault(c=>c.Id == entity.Id);
                    //user.UserName = entity.UserName;
                    user.Password = entity.Password;
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
