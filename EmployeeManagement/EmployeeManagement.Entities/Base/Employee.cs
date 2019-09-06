using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Entities
{
    public abstract class Employee
    {
        #region Properties
        private int employeeId;
        private string employeeType;
        private string name;
        private int bonus;
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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public EmployeeDetails EmployeeDetails
        {
            get { return employeeDetails; }
            set { employeeDetails = value; }
        }
        
        
        #endregion
    }
}
