using EmployeeManagement.Entities;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;

namespace EmployeeManagement.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        #region Class level Parameters
        static string connectionStr = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        SqlConnection sqlCon = new SqlConnection(connectionStr);
        SqlCommand sqlCmd;
        SqlDataAdapter myAdapter = new SqlDataAdapter();
        #endregion
        public Employee Save(Employee employee)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                sqlCmd = new SqlCommand("sp_insert_or_update_employee", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@employeeId", employee.EmployeeId);
                sqlCmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                sqlCmd.Parameters.AddWithValue("@lastName", employee.LastName);
                sqlCmd.Parameters.AddWithValue("@salary", employee.Salary);
                sqlCmd.Parameters.AddWithValue("@bonus", employee.Bonus);
                sqlCmd.Parameters.AddWithValue("@departmentId", employee.DeptID);
                if (employee.ManagerID != -1)
                    sqlCmd.Parameters.AddWithValue("@managerId", employee.ManagerID);
                else
                    sqlCmd.Parameters.AddWithValue("@managerId", DBNull.Value);
                sqlCmd.Parameters.AddWithValue("@phoneNumber", employee.EmployeeDetails.Number);
                sqlCmd.Parameters.AddWithValue("@address", employee.EmployeeDetails.Address);
                sqlCmd.Parameters.AddWithValue("@mailId", employee.EmployeeDetails.Mail);
                sqlCmd.Parameters.AddWithValue("@gender", employee.EmployeeDetails.Gender);
                sqlCmd.Parameters.AddWithValue("@countryId", employee.EmployeeDetails.CountryID);

                sqlCmd.Parameters.AddWithValue("@createdBy", employee.FirstName);
                sqlCmd.Parameters.AddWithValue("@updatedBy", employee.FirstName);

                sqlCmd.Parameters["@employeeId"].Direction = ParameterDirection.InputOutput;
                sqlCmd.ExecuteNonQuery();


                employee.EmployeeId = Convert.ToInt32(sqlCmd.Parameters["@employeeId"].Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlCon.Close();
            }
            return employee;
        }

        public ArrayList GetManager(int deptId)
        {
            sqlCmd = new SqlCommand("select employee_id,first_name,last_name from dbo.EMP_EMPLOYEE where department_id=" + deptId, sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCon.Open();

            // SqlDataAdapter myAdapter = new SqlDataAdapter();
            myAdapter.SelectCommand = sqlCmd;

            IDataReader dr = sqlCmd.ExecuteReader();
            EmployeeFactory empFactory = new EmployeeFactory();
            ArrayList managerList = new ArrayList();
            while (dr.Read())
            {
                int employeeId = Convert.ToInt32(dr["employee_id"]);
                string employeeFirstName = Convert.ToString(dr["first_name"]);
                string employeeLastName = Convert.ToString(dr["last_name"]);
                Employee manager = empFactory.CreateManager(employeeId, employeeFirstName, employeeLastName);
                managerList.Add(manager);
            }
            sqlCon.Close();
            return managerList;
        }
    }
}
