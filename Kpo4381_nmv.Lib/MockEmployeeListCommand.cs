using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4381.nmv.Lib.source.my_classes;

namespace Kpo4381.nmv.Lib
{
    public class MockEmployeeListCommand
    {
        private readonly string _dataFileName = "";
        private List<Employee> _employeeList= null;

        public MockEmployeeListCommand()
        {
            this._employeeList = null;
        }

        public List<Employee> employeeList
        {
            get { return _employeeList; }
        }

        public void Execute()
        {
            {
                Employee employee = new Employee()
                {
                    family = "Иванов",
                    name = "Александр"
                };
                employeeList.Add(employee);    
            }
            {
                Employee employee = new Employee()
                {
                    family = "Петров",
                    name = "Иван"
                };
                employeeList.Add(employee);
            }
        }
    }
}
