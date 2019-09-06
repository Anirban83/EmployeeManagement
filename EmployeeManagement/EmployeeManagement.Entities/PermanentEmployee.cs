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
        public PermanentEmployee(int id, string name, EmployeeDetails empDetails)
        {
            base.EmployeeId = id;
            base.EmployeeType = Constants.EmployeeType.PERMANENT;
            base.Name = name;
            base.EmployeeDetails = empDetails;
        }
        #endregion
    }
}
