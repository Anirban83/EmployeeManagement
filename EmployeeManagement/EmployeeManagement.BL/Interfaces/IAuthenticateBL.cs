using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BL
{
    public interface IAuthenticateBL
    {
        int RegisterUser(string userName, string password, string mail);

        bool AuthenticateUser(string userName, string password);
    }
}
