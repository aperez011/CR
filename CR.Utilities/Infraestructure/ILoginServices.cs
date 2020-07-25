using CR.Entities;
using CR.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Utilities.Infraestructure
{
    public interface ILoginServices : IBaseMethods<User>
    {
        OperationResult<IEnumerable<UserDTO>> GetUsers();
        OperationResult<User> Login(string userName, string password);

    }
}
