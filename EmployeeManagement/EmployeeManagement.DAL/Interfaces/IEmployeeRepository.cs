
using EmployeeManagement.Entities;
using System.Collections;

namespace EmployeeManagement.DAL
{
    public interface IEmployeeRepository
    {
        Employee Save(Employee employee);
        ArrayList GetManager(int deptId);
    }
}
