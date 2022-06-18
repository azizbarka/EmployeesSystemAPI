using EmployeesSystemAPI.Models;
using EmployeesSystemAPI.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeesSystemAPI.Controllers
{
    [ApiController]
    [Route("api/")]
    [EnableCors("Any")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository repository;
        public EmployeeController( EmployeeRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet("emps")]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await repository.GetEmployees();
        }

        [HttpGet("emps/{id}")]
        public async Task<Employee> Get(int id)
        {
            return await repository.GetEmployee(id);
        }

        [HttpPost("add-emp")]
        public async Task<Employee> Post(Employee emp)
        {
            emp.Id = null;
            await repository.AddEmployee(emp);

            return emp;
        }

        [HttpDelete("del-emp/{id}")]
        public async Task<HttpResponseMessage> Delete(int id)
        {
            await repository.DeleteEmployee(id);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

        [HttpPut("upd-emp")]
        public async Task<HttpResponseMessage> Update(Employee emp)
        {
            await repository.UpdateEmployee(emp);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);

        }
    }
}
