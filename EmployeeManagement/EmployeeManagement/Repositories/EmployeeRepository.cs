using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        //readonly is used to make sure that the reference of the object cannot be changed
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync(); //SaveChanges() is used to save the changes to the database

        }

        public async Task DeleteEmployeeAsync(int id)
        {
            var employeeInDb = await _context.Employees.FindAsync(id);
            if (employeeInDb != null)
            {
                _context.Employees.Remove(employeeInDb);
                await _context.SaveChangesAsync();
            } else
            {
                throw new KeyNotFoundException($"Employee with id {id} was not found");
            }
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }
    }
}
