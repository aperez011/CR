using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR.Entities.DTO;
using CR.Utilities;
using CR.Utilities.Infraestructure;

namespace CR.Services
{
    public class ReportServices : IReportServices
    {
        public OperationResult<ReportDTO> GetReportByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public OperationResult<ReportDTO> GetReportByUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
