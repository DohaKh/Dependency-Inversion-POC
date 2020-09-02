using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingFemaleManagersWithoutDIP
{
    /*
     * low-level class which keeps (in a simplified way) track of our employees.
     * With this kind of structure in our EmployeeManager class, we can’t make use of the 
     * _employess list in the EmployeeStatistics class, 
     * so the obvious solution would be to expose that private list.
     */
    public class EmployeeManager
    {
        private readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public List<Employee> Employees => _employees;
    }
}
