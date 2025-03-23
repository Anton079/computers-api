using computers_api.Computers.Dtos;
using computers_api.Computers.Models;

namespace computers_api.Computers.Repository
{
    public interface IComputerRepo
    {
        Task<List<Computer>> GetComputersAsync();

        Task<ComputerResponse> CreateComputerAsync(AddComputerRequest computerReq);

        Task<ComputerResponse> GetComputerMinPrice(int min);

        Task<ComputerResponse> GetComputerMinMaxPrice(int min, int max);

        Task<ComputerResponse> DeleteComputerById(int id);

        Task<ComputerResponse> UpdateComputer(int id, EditComputerRequest computerReq);

        Task<bool> IsDuplicatedAsync(AddComputerRequest computerReq);

        Task<ComputerResponse> FindComputerIdAsync(int id);
    }
}
