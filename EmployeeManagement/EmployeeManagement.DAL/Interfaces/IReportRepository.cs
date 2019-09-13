using System.Data;

namespace EmployeeManagement.DAL
{
    public interface IReportRepository
    {
        DataTable GetReportDetail(string reportType);
    }
}
