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
        IMasterDataBL masterDataBL = new MasterDataBL();
        IEmployeeBL empBL = new EmployeeBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                
                ddlDept.DataSource = masterDataBL.GetDepartment();
                ddlDept.DataTextField = "DeptName";
                ddlDept.DataValueField = "DeptID";
                ddlDept.DataBind();
                ListItem defaultDept = new ListItem("Select a department", "-1");
                ddlDept.Items.Insert(0, defaultDept);

                ddlCountry.DataSource = masterDataBL.GetCountry();
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "CountryID";
                ddlCountry.DataBind();
                ListItem defaultCountry = new ListItem("Select a country", "-1");
                ddlCountry.Items.Insert(0, defaultCountry);

                ListItem defaultManager = new ListItem("Select a manager", "-1");
                ddlManager.Items.Insert(0, defaultManager);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int? managerID = !String.IsNullOrEmpty(ddlManager.SelectedValue) ? Convert.ToInt32(ddlManager.SelectedValue) : (int?)null;
                Employee employee = employeeFactory.CreateEmployee(Constants.EmployeeProperties.DEFAULT_ID, txtFirstName.Text, txtLastName.Text, Convert.ToInt32(ddlDept.SelectedValue), Convert.ToInt32(txtSalary.Text), managerID, txtPhoneNumber.Text, txtAddress.Text, txtMail.Text, Convert.ToChar(rbtnGender.SelectedValue), Convert.ToInt32(ddlCountry.SelectedValue));
                
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

            ddlManager.DataSource = empBL.GetManager(Convert.ToInt32(ddlDept.SelectedValue));
            ddlManager.DataTextField = "ManagerName";
            ddlManager.DataValueField = "ManagerID";
            ddlManager.DataBind();
            ListItem defaultManager = new ListItem("Select a manager", "-1");
            ddlManager.Items.Insert(0, defaultManager);
        }
    }
}