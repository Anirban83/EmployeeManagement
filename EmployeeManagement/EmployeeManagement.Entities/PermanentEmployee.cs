using EmployeeManagement.Common;

namespace EmployeeManagement.Entities
{
    public class PermanentEmployee : Employee
    {
        #region Constructor
        /// <summary>
        /// Constructor for Permanent Employee
        /// </summary>
        /// <param name="name">Employee Name</param>
        /// <param name="address">Employee Address</param>
        public PermanentEmployee(int id, string firstName, string lastName, int deptID, int salary, int managerID, EmployeeDetails empDetails)
        {
            base.EmployeeId = id;
            base.EmployeeType = Constants.EmployeeType.PERMANENT;
            base.FirstName = firstName;
            base.LastName = lastName;
            base.DeptID = deptID;
            base.Salary = salary;
            base.ManagerID = managerID;
            base.EmployeeDetails = empDetails;
        }

        public PermanentEmployee(int id, string firstName, string lastName)
        {
            base.EmployeeId = id;
            base.EmployeeType = Constants.EmployeeType.PERMANENT;
            base.FirstName = firstName;
            base.LastName = lastName;
        }
        #endregion
    }
}
