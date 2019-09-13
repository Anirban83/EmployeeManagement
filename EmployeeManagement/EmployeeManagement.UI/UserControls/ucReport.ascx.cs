using EmployeeManagement.BL;
using EmployeeManagement.Common;
using System;
using System.Data;

namespace EmployeeManagement.UI
{
    public partial class ucReport : System.Web.UI.UserControl
    {
        public string reportType = string.Empty;
        private DataTable dtblReportResult;
        IReportBL reportBL = new ReportBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                switch (reportType)
                {
                    case Constants.ReportType.CountryReport:
                        LoadCountryReport();
                        break;
                    case Constants.ReportType.GenderReport:
                        LoadGenderReport();
                        break;
                    default:
                        lblReportType.Text = "Report not found!";
                        break;
                }

                FillDataGridView();
            }
        }

        private void LoadCountryReport()
        {
            lblReportType.Text = "Country Report";            
            dtblReportResult = reportBL.GetReportDetail(Constants.ReportType.CountryReport);
        }

        private void LoadGenderReport()
        {
            lblReportType.Text = "Gender Report";
            dtblReportResult = reportBL.GetReportDetail(Constants.ReportType.GenderReport);
        }

        private void FillDataGridView()
        {
            if (dtblReportResult != null)
            {
                dgvReportResult.DataSource = dtblReportResult;
                dgvReportResult.DataBind();
            }
        }
    }
}