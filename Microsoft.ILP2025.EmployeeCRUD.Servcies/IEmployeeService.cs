﻿using Microsoft.ILP2025.EmployeeCRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.ILP2025.EmployeeCRUD.Servcies
{
    public interface IEmployeeService
    {
        Task<EmployeeEntity?> GetEmployee(int id);

        Task<List<EmployeeEntity>> GetAllEmployees();
    }
}
