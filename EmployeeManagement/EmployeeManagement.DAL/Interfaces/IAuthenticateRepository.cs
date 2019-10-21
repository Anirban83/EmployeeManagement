using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL
{
    public interface IAuthenticateRepository
    {
        int RegisterUser(string userName, string password, string mail);

        bool AuthenticateUser(string userName, string password);
    }
}
