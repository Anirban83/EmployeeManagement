using EmployeeManagement.DAL;
using EmployeeManagement.Entities;
using System;
using System.Collections;
using System.Configuration;
using System.Xml.Linq;

namespace EmployeeManagement.BL
{
    public class EmployeeBL : IEmployeeBL
    {
        #region Private Variables
        string bonusXmlPath = string.Format(@"{0}\Xmls\{1}", AppDomain.CurrentDomain.RelativeSearchPath, ConfigurationManager.AppSettings["BONUS_XML"]);
        IEmployeeRepository empRepo;
        #endregion

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
            empRepo = new EmployeeRepository();
            return empRepo.Save(employee);
        }


        public ArrayList GetManager(int deptId)
        {
            empRepo = new EmployeeRepository();
            return empRepo.GetManager(deptId);
        }
        #endregion

        #region Private Methods
        private int CalculateBonus()
        {
            XElement bonusXml = XElement.Load(bonusXmlPath);
            return 20;
        }
        #endregion
    }
}
