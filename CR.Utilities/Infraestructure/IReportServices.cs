using CR.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Utilities.Infraestructure
{
    public interface IReportServices
    {
        OperationResult<ReportDTO> GetReportByDate(DateTime date);

        OperationResult<ReportDTO> GetReportByUser(int userId);
    }
}
