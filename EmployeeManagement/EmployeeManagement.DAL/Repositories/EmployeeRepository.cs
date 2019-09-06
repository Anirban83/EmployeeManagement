using EmployeeManagement.Entities;
using System;

namespace EmployeeManagement.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee Save(Employee employee)
        {
            employee.EmployeeId = 1;
            return employee;
        }
    }
}
