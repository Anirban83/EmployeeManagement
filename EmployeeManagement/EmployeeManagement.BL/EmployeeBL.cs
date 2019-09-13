
using EmployeeManagement.DAL;
using EmployeeManagement.Entities;
using System.Collections;

namespace EmployeeManagement.BL
{
    public class EmployeeBL : IEmployeeBL
    {
        #region Public Methods
        /// <summary>
        /// This method calculates the bonus for an employee.
        /// Calls the DAL Repository to save the employee.
        /// Returns the new employee to UI layer
        /// </summary>
        /// <param name="employee"></param>
        public Employee Save(Employee employee)
        {
            employee.Bonus = CalculateBonus();
            IEmployeeRepository empRepo = new EmployeeRepository();
            return empRepo.Save(employee);
        }
        #endregion

        #region Private Methods
        private int CalculateBonus()
        {
            return 20;
        }
        #endregion
    }
    public class LoadFirstBL : ILoadFirstBL
    {
        public ArrayList DeptIDSave()
        {
            ILoadFirstRepository loadFirst = new LoadFirstRepository();
            return loadFirst.GetDeptID();
        }
        public ArrayList ShowManager(int key)
        {
            ILoadFirstRepository loadFirst = new LoadFirstRepository();
            return loadFirst.ShowManagerNames(key);
        }
        public ArrayList CountryIDSave()
        {
            ILoadFirstRepository loadFirst = new LoadFirstRepository();
            return loadFirst.GetCountryID();
        }

    }
}
