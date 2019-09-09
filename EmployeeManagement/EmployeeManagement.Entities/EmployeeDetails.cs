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
        private int employeeDetailsID;
        private string number;
        private string mail;
        private char gender;
        private int countryID;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int EmployeeDetailsID
        {
            get { return employeeDetailsID; }
            set { employeeDetailsID = value; }
        }
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int CountryID
        {
            get { return countryID; }
            set { countryID = value; }
        }
        #endregion

        #region Constructor
        public EmployeeDetails(int employeeDetailsID,string number,string address,string mail,char gender,int countryID)
        {
            this.EmployeeDetailsID = employeeDetailsID;
            this.Number = number;
            this.Address = address;
            this.Mail = mail;
            this.Gender = gender;
            this.CountryID = countryID;
        }
        #endregion
    }
}
