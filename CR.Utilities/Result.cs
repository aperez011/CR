using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Utilities
{
    public class OperationResult
    {

        public bool Success { get; set; }
        public string Message { get; set; }

        public static OperationResult SetSucces()
        {
            return new OperationResult
            {
                Success = true
            };
        }

        public static OperationResult SetFail(string message)
        {
            return new OperationResult
            {
                Success = false,
                Message = message
            };
        }
    }

    public class OperationResult<T> : OperationResult
    {
        public T Data { get; set; }

        public static OperationResult<T> SetSucces(T data)
        {
            return new OperationResult<T>
            {
                Success = true,
                Data = data
            };
        }

        public static OperationResult<T> SetFail(string message)
        {
            return new OperationResult<T>
            {
                Success = false,
                Message = message
            };
        }


    }
}
