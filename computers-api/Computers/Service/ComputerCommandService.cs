using AutoMapper;
using computers_api.Computers.Dtos;
using computers_api.Computers.Exceptions;
using computers_api.Computers.Repository;

namespace computers_api.Computers.Service
{
    public class ComputerCommandService : IComputerCommandService
    {
        private IComputerRepo _computerRepo;
        private IMapper _mapper;

        public ComputerCommandService(IComputerRepo computerRepo, IMapper mapper)
        {
            this._computerRepo = computerRepo;
            this._mapper = mapper;
        }

        public async Task<ComputerResponse> CreateComputerAsync(AddComputerRequest computerReq)
        {
            if(computerReq == null) { throw new NullComputerException(); }

            if(await _computerRepo.IsDuplicatedAsync(computerReq)) { throw new ComputerExistException(); }

            ComputerResponse resp = await _computerRepo.CreateComputerAsync(computerReq);

            return resp;
        }

        public async Task<ComputerResponse> EditComputer(int id, EditComputerRequest editComputerRequest)
        {
            var existingComputer = await _computerRepo.FindComputerIdAsync(id);

            if (existingComputer == null) { throw new NullComputerException(); }

            if (existingComputer.Model == null) { throw new NullComputerException(); }
            if (existingComputer.Type == null) { throw new NullComputerException(); }
            if (existingComputer.Price == null) { throw new NullComputerException(); }

            ComputerResponse resp = await _computerRepo.UpdateComputer(id, editComputerRequest);

            return resp;
        }

        public async Task<ComputerResponse> DeleteComputerById(int id)
        {
            if (id <= 0) { throw new IdNotFoundException(); }

            var computer = await _computerRepo.DeleteComputerById(id);

            if (computer == null) { throw new NullComputerException(); }

            return _mapper.Map<ComputerResponse>(computer);
        }
    }
}
