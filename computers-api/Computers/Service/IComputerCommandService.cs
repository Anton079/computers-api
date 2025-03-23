using computers_api.Computers.Dtos;

namespace computers_api.Computers.Service
{
    public interface IComputerCommandService
    {
        Task<ComputerResponse> CreateComputerAsync(AddComputerRequest computerReq);

        Task<ComputerResponse> DeleteComputerById(int id);

        Task<ComputerResponse> EditComputer(int id, EditComputerRequest editComputerRequest);


    }
}
