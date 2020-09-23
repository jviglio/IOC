using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Juan", Department = "d1", Email = "e1"},
                new Employee(){Id = 2, Name = "Ana", Department = "d2", Email = "e2"},
                new Employee(){Id = 3, Name = "Ale", Department = "d3", Email = "e3"} 
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.Where(x => x.Id == Id).FirstOrDefault();
        }
    }
}
