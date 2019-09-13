namespace EmployeeManagement.Entities
{
    public class EmployeeFactory
    {
        public Employee CreateEmployee(int id, string firstName, string lastName, int deptID, int salary, int? managerID, string number, string address, string mail, char gender, int countryID)
        {
            EmployeeDetails empDetails = new EmployeeDetails(number, address, mail, gender, countryID);
            return new PermanentEmployee(id, firstName, lastName, deptID, salary, managerID, empDetails);
        }
    }
}