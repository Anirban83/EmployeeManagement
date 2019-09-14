using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL
{
    public interface IMasterDataRepository
    {
        ArrayList GetDeptID();
        ArrayList GetCountryID();
        ArrayList ShowManagerNames(int key);
    }
}
