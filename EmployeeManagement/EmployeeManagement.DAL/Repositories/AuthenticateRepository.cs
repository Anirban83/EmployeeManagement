using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL
{
    public class AuthenticateRepositrory : IAuthenticateRepository
    {
        #region Class level Parameters
        static string connectionStr = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        SqlConnection sqlCon = new SqlConnection(connectionStr);
        SqlCommand sqlCmd;
        #endregion

        public int RegisterUser(string userName, string password, string mail)
        {
            try
            {
                using (sqlCon)
                {
                    SqlCommand cmd = new SqlCommand("sp_register_user", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramUsername = new SqlParameter("@userName", userName);
                    SqlParameter paramPassword = new SqlParameter("@password", password);
                    SqlParameter paramMail = new SqlParameter("@mailId", mail);

                    cmd.Parameters.Add(paramUsername);
                    cmd.Parameters.Add(paramPassword);
                    cmd.Parameters.Add(paramMail);

                    sqlCon.Open();

                    int returnCode = (int)cmd.ExecuteScalar();
                    return returnCode;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public bool AuthenticateUser(string userName, string password)
        {
            try
            {
                // SqlConnection is in System.Data.SqlClient namespace
                using (sqlCon)
                {
                    SqlCommand cmd = new SqlCommand("sp_authenticate_user", sqlCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    // SqlParameter is in System.Data namespace
                    SqlParameter paramUsername = new SqlParameter("@userName", userName);
                    SqlParameter paramPassword = new SqlParameter("@password", password);

                    cmd.Parameters.Add(paramUsername);
                    cmd.Parameters.Add(paramPassword);

                    sqlCon.Open();
                    int returnCode = (int)cmd.ExecuteScalar();
                    return returnCode == 1 ? true : false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
