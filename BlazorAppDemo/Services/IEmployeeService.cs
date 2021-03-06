﻿using BlazorAppDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppDemo.Services
{
    public interface IEmployeeService
    {
        Task Add(Employee employee);
        
        Task<Employee> GetById(int id);

        Task<Employee> Frie(int id);

        Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId);
    }
}
