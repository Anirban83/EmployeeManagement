
namespace EmployeeManagement.Entities
{
    public class EmployeeFactory
    {
        public Employee CreateEmployee(int id, string name, string address)
        {
            EmployeeDetails empDetails = new EmployeeDetails(address);
            return new PermanentEmployee(id, name, empDetails);
        }
    }
}
