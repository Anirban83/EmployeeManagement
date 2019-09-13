using EmployeeManagement.DAL;
using System.Data;

namespace EmployeeManagement.BL
{
    public class ReportBL : IReportBL
    {
        IReportRepository reportRepository = new ReportRepository();
        public DataTable GetReportDetail(string reportType)
        {            
            return reportRepository.GetReportDetail(reportType);
        }
    }
}
