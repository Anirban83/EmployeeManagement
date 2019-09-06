
using EmployeeManagement.Entities;

namespace EmployeeManagement.DAL
{
    public interface IEmployeeRepository
    {
        Employee Save(Employee employee);
    }
}
