
using EmployeeManagement.Entities;
using System.Collections;


namespace EmployeeManagement.BL
{
    public interface IEmployeeBL
    {
        Employee Save(Employee employee);
        
        ArrayList GetManager(int key);
    }
}
