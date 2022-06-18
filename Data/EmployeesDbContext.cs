using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesSystemAPI.Data
{
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Models.Employee> Employees { get; set;}
    }
}
