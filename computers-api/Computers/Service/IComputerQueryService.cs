using computers_api.Computers.Dtos;

namespace computers_api.Computers.Service
{
    public interface IComputerQueryService
    {
        Task<List<ComputerResponse>> GetAllComputer();
    }
}
