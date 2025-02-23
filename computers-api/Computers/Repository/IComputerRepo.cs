using computers_api.Computers.Dtos;
using computers_api.Computers.Models;

namespace computers_api.Computers.Repository
{
    public interface IComputerRepo
    {
        Task<List<Computer>> GetComputersAsync();

        Task<ComputerResponse> CreateComputerAsync(ComputerRequest computerReq);
    }
}
