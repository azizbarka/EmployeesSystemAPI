using EmployeesSystemAPI.Data;
using EmployeesSystemAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesSystemAPI.Repositories
{
    public class EmployeeRepository
    {
        private readonly EmployeesDbContext context;

        public EmployeeRepository(EmployeesDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Employee>> GetEmployees()
        {
            return await context.Employees.ToListAsync();
        }
        public async Task AddEmployee(Employee item)
        {
            await context.Employees.AddAsync(item);
            await context.SaveChangesAsync();
        }
        public async Task<Employee> GetEmployee(int id)
        {
            return await context.Employees.FindAsync(id);
        }
        public async Task UpdateEmployee(Employee item)
        {
            context.Employees.Update(item);
            await context.SaveChangesAsync();
        }
        public async Task<bool> DeleteEmployee(int id)
        {
            var post = await context.Employees.FindAsync(id);
            if (post == null) return false;
            context.Employees.Remove(post);
            await context.SaveChangesAsync();
            return true;
        }
    }
}

