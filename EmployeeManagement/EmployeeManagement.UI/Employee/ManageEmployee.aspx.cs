using System;
using EmployeeManagement.Entities;
using EmployeeManagement.BL;
using EmployeeManagement.Common;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagement.UI
{
    public partial class ManageEmployee : System.Web.UI.Page
    {
        EmployeeFactory employeeFactory = new EmployeeFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                IMasterDataBL lfBL = new MasterDataBL();
                ddlDept.DataSource = lfBL.DeptIDSave();
                ddlDept.DataTextField = "DeptName";
                ddlDept.DataValueField = "DeptID";
                ddlDept.DataBind();
                ddlCountry.DataSource = lfBL.CountryIDSave();
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "CountryID";
                ddlCountry.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int? managerID = !String.IsNullOrEmpty(ddlManager.SelectedValue)?Convert.ToInt32(ddlManager.SelectedValue):(int?)null;
                Employee employee = employeeFactory.CreateEmployee(Constants.EmployeeProperties.DEFAULT_ID, txtFirstName.Text, txtLastName.Text, Convert.ToInt32(ddlDept.SelectedValue), Convert.ToInt32(txtSalary.Text), managerID, txtPhoneNumber.Text, txtAddress.Text, txtMail.Text, Convert.ToChar(rbtnGender.SelectedValue), Convert.ToInt32(ddlCountry.SelectedValue));
                IEmployeeBL empBL = new EmployeeBL();
                employee = empBL.Save(employee);

                LoadEmployeeData(employee);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }



        #region Private Methods
        private void LoadEmployeeData(Employee employee)
        {
            txtEmployeeId.Text = employee.EmployeeId.ToString();
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtSalary.Text = Convert.ToString(employee.Salary);
            txtBonus.Text = employee.Bonus.ToString();
            txtPhoneNumber.Text = employee.EmployeeDetails.Number;
            txtAddress.Text = employee.EmployeeDetails.Address;
            txtMail.Text = employee.EmployeeDetails.Mail;
            if (employee.EmployeeDetails.Gender == 'M')
            { rbtnGender.Items[0].Selected = true; }
            else if (employee.EmployeeDetails.Gender == 'F')
            { rbtnGender.Items[1].Selected = true; }
            else
            { rbtnGender.Items[2].Selected = true; }
        }
        #endregion

        protected void ddlDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMasterDataBL lfBL = new MasterDataBL();
            ddlManager.DataSource = lfBL.ShowManager(Convert.ToInt32(ddlDept.SelectedValue));
            ddlManager.DataTextField = "ManagerName";
            ddlManager.DataValueField = "ManagerID";
            ddlManager.DataBind();
            ddlManager.Items.Insert(0, new ListItem("None", ""));
        }
    }
}