using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BL
{
    public interface IMasterDataBL
    {
            ArrayList GetDepartment();
            ArrayList GetCountry();
    }
}
