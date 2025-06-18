using Microsoft.ILP2025.EmployeeCRUD.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.ILP2025.EmployeeCRUD.Repositores
{
    public interface IEmployeeRepository
    {
        Task<EmployeeEntity?> GetEmployee(int id);
        Task<List<EmployeeEntity>> GetAllEmployees();
        Task AddEmployee(EmployeeEntity employee);
        Task UpdateEmployee(int id, EmployeeEntity employee);
        Task DeleteEmployee(int id);
    }
}
