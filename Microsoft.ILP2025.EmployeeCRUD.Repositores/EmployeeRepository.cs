using Microsoft.ILP2025.EmployeeCRUD.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.ILP2025.EmployeeCRUD.Repositores
{
    public class EmployeeRepository : IEmployeeRepository
    {
        // 🔒 Static list simulating database
        private static List<EmployeeEntity> employees = new List<EmployeeEntity>
        {
            new EmployeeEntity { Id = 1, Name = "Pradip", Designation = "Software Engineer", YOE = 3, Salary = 60000 },
            new EmployeeEntity { Id = 2, Name = "Shrikanth", Designation = "Senior Developer", YOE = 5, Salary = 90000 }
        };

        public async Task<List<EmployeeEntity>> GetAllEmployees()
        {
            return await Task.FromResult(employees);
        }

        public async Task<EmployeeEntity?> GetEmployee(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            return await Task.FromResult(emp);
        }

        public async Task AddEmployee(EmployeeEntity employee)
        {
            // For simplicity, auto-increment the ID
            employee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(employee);
            await Task.CompletedTask;
        }

        public async Task UpdateEmployee(int id, EmployeeEntity updatedEmployee)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                emp.Name = updatedEmployee.Name;
                emp.Designation = updatedEmployee.Designation;
                emp.YOE = updatedEmployee.YOE;
                emp.Salary = updatedEmployee.Salary;
            }

            await Task.CompletedTask;
        }

        public async Task DeleteEmployee(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                employees.Remove(emp);
            }

            await Task.CompletedTask;
        }
    }
}
