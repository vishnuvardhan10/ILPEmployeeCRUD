using Microsoft.ILP2025.EmployeeCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ILP2025.EmployeeCRUD.Repositores
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public async Task<List<EmployeeEntity>> GetAllEmployees()
        {
            return await Task.FromResult(this.GetEmployees());
        }

        public async Task<EmployeeEntity> GetEmployee(int id)
        {
            var employees = this.GetEmployees();

            return await Task.FromResult(employees.FirstOrDefault(e => e.Id == id));
        }

        private List<EmployeeEntity> GetEmployees()
        {
            var employees = new List<EmployeeEntity>();

            employees.Add(new EmployeeEntity { Id = 1, Name = "Pradip" });
            employees.Add(new EmployeeEntity { Id = 2, Name = "Shrikanth" });

            return employees;
        }
    }
}
