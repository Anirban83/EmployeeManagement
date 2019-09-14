using EmployeeManagement.DAL;
using System.Collections;

namespace EmployeeManagement.BL
{
    public class MasterDataBL : IMasterDataBL
    {
        public ArrayList DeptIDSave()
        {
            IMasterDataRepository masterData = new MasterDataRepository();
            return masterData.GetDeptID();
        }
        public ArrayList ShowManager(int key)
        {
            IMasterDataRepository masterData = new MasterDataRepository();
            return masterData.ShowManagerNames(key);
        }
        public ArrayList CountryIDSave()
        {
            IMasterDataRepository masterData = new MasterDataRepository();
            return masterData.GetCountryID();
        }

    }
}
