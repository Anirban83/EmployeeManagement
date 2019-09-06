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
                Employee employee = employeeFactory.CreateEmployee(Constants.EmployeeProperties.DEFAULT_ID, txtName.Text, txtAddress.Text);
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
            txtName.Text = employee.Name;
            txtBonus.Text = employee.Bonus.ToString();
            txtAddress.Text = employee.EmployeeDetails.Address;
        }
        #endregion
    }
}