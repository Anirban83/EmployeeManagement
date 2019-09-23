using EmployeeManagement.DAL;
using System.Data;

namespace EmployeeManagement.BL
{
    public class ReportBL : IReportBL
    {
        IReportRepository reportRepo = new ReportRepository();
        public DataTable GetReportDetail(string reportType)
        {
            return reportRepo.GetReportDetail(reportType);
        }
    }
}
