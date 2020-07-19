﻿using CR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Utilities.Infraestructure
{
    public interface ILoginServices : IBaseMethods<User>
    {
        OperationResult<User> Login(string userName, string password);


    }
}
