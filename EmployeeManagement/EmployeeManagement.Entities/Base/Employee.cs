using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Entities
{
    public abstract class Employee
    {
        //fields for employee given here
        #region Properties
        private int employeeId;
        private string employeeType;
        private string firstName;
        private string lastName;
        private int deptID;
        private int salary;
        private int bonus;
        private int managerID;
        private EmployeeDetails employeeDetails;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public int ManagerID
        {
            get { return managerID; }
            set { managerID = value; }
        }

        public EmployeeDetails EmployeeDetails
        {
            get { return employeeDetails; }
            set { employeeDetails = value; }
        }
        
        
        #endregion
    }
}
