using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Entities
{

    public class Department
    {
        int deptID;
        string deptName;

        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }
        public int DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }
        public Department(int ID,string name)
        {
            this.DeptID = ID;
            this.DeptName = name;
        }
    }
}

