using EmployeeManagement.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BL
{
    public class AuthenticateBL : IAuthenticateBL
    {
        #region Private Variables
        IAuthenticateRepository authRepo;
        #endregion
        public int RegisterUser(string userName, string password, string mail)
        {
            authRepo = new AuthenticateRepositrory();
            return authRepo.RegisterUser(userName, password, mail);
        }


        public bool AuthenticateUser(string userName, string password)
        {
            authRepo = new AuthenticateRepositrory();
            return authRepo.AuthenticateUser(userName, password);
        }
    }
}
