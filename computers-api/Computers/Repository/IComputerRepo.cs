using computers_api.Computers.Models;

namespace computers_api.Computers.Repository
{
    public interface IComputerRepo
    {
        Task<List<Computer>> GetComputersAsync();
    }
}
