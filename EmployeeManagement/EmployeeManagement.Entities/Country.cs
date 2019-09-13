using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Entities
{
    public class Country
    {
        int countryID;
        string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
        public int CountryID
        {
            get { return countryID; }
            set { countryID = value; }
        }
        public Country(int id,string name)
        {
            this.CountryID = id;
            this.CountryName = name;
        }
    }
}
