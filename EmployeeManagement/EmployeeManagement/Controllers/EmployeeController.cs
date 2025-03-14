﻿using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.Models;
using EmployeeManagement.Repositories;
namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //we use I for interface, not strictly the implemented type for dynamic binding and loose coupling.
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployeesAsync()
        {
            var allEmployees = await _employeeRepository.GetAllAsync();
            return Ok(allEmployees);
        }

        //If there is an id in the route, it will be passed as a parameter to the GetByIdAsync method
        //If not, we use the getall method
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeById(int id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest();
            }
            await _employeeRepository.AddEmployeeAsync(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id }, employee);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployeeById(int id)
        {
            await _employeeRepository.DeleteEmployeeAsync(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> UpdateEmployeeAsync (int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid == false)
            {
                return BadRequest();
            }
            await _employeeRepository.UpdateEmployeeAsync(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id }, employee);
        }
    }
}
