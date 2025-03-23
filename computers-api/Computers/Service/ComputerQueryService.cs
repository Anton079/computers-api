using AutoMapper;
using computers_api.Computers.Dtos;
using computers_api.Computers.Repository;

namespace computers_api.Computers.Service
{
    public class ComputerQueryService : IComputerQueryService
    {
        private IComputerRepo _computerRepo;
        private IMapper _mapper;

        public ComputerQueryService(IComputerRepo computerRepo, IMapper mapper)
        {
            this._computerRepo = computerRepo;
            this._mapper = mapper;
        }

        public async Task<List<ComputerResponse>> GetAllComputer()
        {
            var computer = await _computerRepo.GetComputersAsync();

            return _mapper.Map<List<ComputerResponse>>(computer);
        }
    }
}
