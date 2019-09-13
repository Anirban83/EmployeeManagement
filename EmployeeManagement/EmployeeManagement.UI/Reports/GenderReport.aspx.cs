using EmployeeManagement.Common;
using System;

namespace EmployeeManagement.UI
{
    public partial class GenderReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ucReport.reportType = Constants.ReportType.GenderReport;
        }
    }
}