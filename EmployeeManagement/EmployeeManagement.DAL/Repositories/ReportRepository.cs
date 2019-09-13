
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagement.DAL
{
    public class ReportRepository : IReportRepository
    {

        #region Class level parameters
        static string connectionStr = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        SqlConnection sqlCon = new SqlConnection(connectionStr);        
        #endregion


        public DataTable GetReportDetail(string reportType)
        {
            DataTable dtblReportResult = new DataTable();

            using (sqlCon)
            {
                SqlCommand sqlCmd = new SqlCommand("sp_get_report_details", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@reportType", reportType);

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                sqlDA.Fill(dtblReportResult);
            }

            return dtblReportResult;
        }
    }
}
