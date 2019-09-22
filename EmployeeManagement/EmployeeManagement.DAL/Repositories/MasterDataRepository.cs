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
        public ArrayList GetCountry()
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
        public ArrayList GetDepartment()
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
        
    }
}
