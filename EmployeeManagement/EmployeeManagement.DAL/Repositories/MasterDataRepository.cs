using EmployeeManagement.Entities;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagement.DAL
{

    public class MasterDataRepository : IMasterDataRepository
    {
        static string connectionStr = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        SqlConnection sqlCon = new SqlConnection(connectionStr);
        SqlCommand sqlCmd;
        SqlDataAdapter myAdapter = new SqlDataAdapter();
        public ArrayList GetCountryID()
        {
            sqlCmd = new SqlCommand("select country_id,country_name from dbo.COU_COUNTRY", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCon.Open();

            //SqlDataAdapter myAdapter = new SqlDataAdapter();
            myAdapter.SelectCommand = sqlCmd;

            IDataReader dr = sqlCmd.ExecuteReader();

            ArrayList countryList = new ArrayList();
            while (dr.Read())
            {
                int storingID = Convert.ToInt32(dr["country_id"]);
                string storingName = Convert.ToString(dr["country_name"]);
                Country dept = new Country(storingID, storingName);
                countryList.Add(dept);
            }
            sqlCon.Close();
            return countryList;
        }
        public ArrayList GetDeptID()
        {
            sqlCmd = new SqlCommand("select department_id,department_name from dbo.DEP_DEPARTMENT order by department_id ", sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCon.Open();

            // SqlDataAdapter myAdapter = new SqlDataAdapter();
            myAdapter.SelectCommand = sqlCmd;

            IDataReader dr = sqlCmd.ExecuteReader();

            ArrayList deptList = new ArrayList();
            while (dr.Read())
            {
                int storingID = Convert.ToInt32(dr["department_id"]);
                string storingName = Convert.ToString(dr["department_name"]);
                Department dept = new Department(storingID, storingName);
                deptList.Add(dept);
            }
            sqlCon.Close();
            return deptList;
        }
        public ArrayList ShowManagerNames(int key)
        {
            sqlCmd = new SqlCommand("select employee_id,concat(first_name,' ',last_name) as employee_name from dbo.EMP_EMPLOYEE where department_id=" + key, sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCon.Open();

            // SqlDataAdapter myAdapter = new SqlDataAdapter();
            myAdapter.SelectCommand = sqlCmd;

            IDataReader dr = sqlCmd.ExecuteReader();

            ArrayList managerList = new ArrayList();
            while (dr.Read())
            {
                int storingID = Convert.ToInt32(dr["employee_id"]);
                string storingName = Convert.ToString(dr["employee_name"]);
                Manager manager = new Manager(storingID, storingName);
                managerList.Add(manager);
            }
            sqlCon.Close();
            return managerList;
        }
    }
}
