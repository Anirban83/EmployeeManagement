using System;
using EmployeeManagement.Entities;
using EmployeeManagement.BL;
using EmployeeManagement.Common;

namespace EmployeeManagement.UI
{
    public partial class ManageEmployee : System.Web.UI.Page
    {
        EmployeeFactory employeeFactory = new EmployeeFactory();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = employeeFactory.CreateEmployee(Constants.EmployeeProperties.DEFAULT_ID, txtFirstName.Text, txtLastName.Text,Convert.ToInt32(txtDeptID.Text),Convert.ToInt32(txtSalary.Text),Convert.ToInt32(txtManagerID.Text), Constants.EmployeeProperties.DEFAULT_ID,txtNumber.Text,txtAddress.Text,txtMail.Text,Convert.ToChar(rbtnGender.SelectedValue),Convert.ToInt32(txtCountryID.Text));
                IEmployeeBL empBL = new EmployeeBL();
                employee = empBL.Save(employee);

                LoadEmployeeData(employee);
            }
            catch(Exception ex)
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
            txtDeptID.Text = Convert.ToString(employee.DeptID);
            txtSalary.Text = Convert.ToString(employee.Salary);
            txtBonus.Text = employee.Bonus.ToString();
            txtManagerID.Text = Convert.ToString(employee.ManagerID);
            txtNumber.Text = employee.EmployeeDetails.Number;
            txtAddress.Text = employee.EmployeeDetails.Address;
            txtMail.Text = employee.EmployeeDetails.Mail;
            if (employee.EmployeeDetails.Gender=='M')
            { rbtnGender.Items[0].Selected = true; }
            else if (employee.EmployeeDetails.Gender == 'F')
            { rbtnGender.Items[1].Selected = true; }
            else
            { rbtnGender.Items[2].Selected = true; }
            txtCountryID.Text = Convert.ToString(employee.EmployeeDetails.CountryID);
        }
        #endregion
    }
}