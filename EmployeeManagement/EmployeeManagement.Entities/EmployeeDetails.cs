using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Entities
{
    public class EmployeeDetails
    {
        #region Properties
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        #endregion

        #region Constructor
        public EmployeeDetails(string address)
        {
            this.Address = address;
        }
        #endregion
    }
}
