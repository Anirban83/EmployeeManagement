
using System.Data;

namespace EmployeeManagement.BL
{
    public interface IReportBL
    {
        DataTable GetReportDetail(string reportType);
    }
}
