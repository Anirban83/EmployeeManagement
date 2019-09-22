using EmployeeManagement.DAL;
using System.Collections;

namespace EmployeeManagement.BL
{
    public class MasterDataBL : IMasterDataBL
    {
        IMasterDataRepository masterDataRepo;
        public ArrayList GetDepartment()
        {
            masterDataRepo = new MasterDataRepository();
            return masterDataRepo.GetDepartment();
        }

        public ArrayList GetCountry()
        {
            masterDataRepo = new MasterDataRepository();
            return masterDataRepo.GetCountry();
        }

    }
}
