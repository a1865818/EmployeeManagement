using EmployeeManagement.Models;
namespace EmployeeManagement.Repositories
{
    public interface IEmployeeRepository
    {
        //Task is a generic type used to represent an asynchronous operation
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<Employee?> GetByIdAsync(int id);//The <> is return type
        Task AddEmployeeAsync(Employee employee);
        Task UpdateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int id);

    }
}
