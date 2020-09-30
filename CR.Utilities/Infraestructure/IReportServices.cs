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
        OperationResult<IEnumerable<FilterInformation>> GetFilterInfoByDate(DateTime startDate, DateTime endDate);
        OperationResult<IEnumerable<ReportDTO>> GetReportByDate(DateTime date);
        OperationResult<IEnumerable<ReportDTO>> GetReportByUser(int userId);
        OperationResult<ReportDTO> GetReportBy(int userId, DateTime date);
    }
}
