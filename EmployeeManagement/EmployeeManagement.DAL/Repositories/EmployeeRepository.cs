using EmployeeManagement.Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagement.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        #region Class level Parameters
        static string connectionStr = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        SqlConnection sqlCon = new SqlConnection(connectionStr);
        #endregion
        public Employee Save(Employee employee)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlCommand sqlCmd = new SqlCommand("sp_insert_or_update_employee", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@employeeId", employee.EmployeeId);
                sqlCmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                sqlCmd.Parameters.AddWithValue("@lastName", employee.LastName);
                sqlCmd.Parameters.AddWithValue("@salary", employee.Salary);
                sqlCmd.Parameters.AddWithValue("@bonus", employee.Bonus=60);
                sqlCmd.Parameters.AddWithValue("@departmentId", employee.DeptID);
                sqlCmd.Parameters.AddWithValue("@managerId", employee.ManagerID);
                sqlCmd.Parameters.AddWithValue("@phoneNumber", employee.EmployeeDetails.Number);
                sqlCmd.Parameters.AddWithValue("@address", employee.EmployeeDetails.Address);
                sqlCmd.Parameters.AddWithValue("@mailId", employee.EmployeeDetails.Mail);
                sqlCmd.Parameters.AddWithValue("@gender", employee.EmployeeDetails.Gender);
                sqlCmd.Parameters.AddWithValue("@countryId", employee.EmployeeDetails.CountryID);

                sqlCmd.Parameters.AddWithValue("@createdBy", employee.FirstName);
                sqlCmd.Parameters.AddWithValue("@updatedBy", employee.FirstName);

                int i = sqlCmd.ExecuteNonQuery();
                if (i <= 0)
                {
                    employee = null;
                }
            }
            catch(Exception ex){
                
            }
            finally{
                sqlCon.Close();
            }
            return employee;
        }
    }
}
