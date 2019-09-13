using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Entities
{

    public class Manager
    {
        int managerID;
        string managerName;

        public string ManagerName
        {
            get { return managerName; }
            set { managerName = value; }
        }
        public int ManagerID
        {
            get { return managerID; }
            set { managerID = value; }
        }
        public Manager(int ID, string name)
        {
            this.ManagerID = ID;
            this.ManagerName = name;
        }
    }
}
