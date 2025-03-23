using AutoMapper;
using computers_api.Computers.Dtos;
using computers_api.Computers.Models;
using computers_api.Data.Migrations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace computers_api.Computers.Repository
{
    public class ComputerRepo : IComputerRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public ComputerRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<Computer>> GetComputersAsync()
        {
            return await _appDbContext.Computers.ToListAsync();
        }

        public async Task<ComputerResponse> CreateComputerAsync (AddComputerRequest computerReq)
        {
            Computer computer = _mapper.Map<Computer>(computerReq);

            _appDbContext.Computers.Add(computer);

            await _appDbContext.SaveChangesAsync();

            ComputerResponse response = _mapper.Map<ComputerResponse>(computer);

            return response;
        }

        public async Task<ComputerResponse> GetComputerMinPrice(int minPrice)
        {
            var computer = await _appDbContext.Computers
                .Where(computer => computer.Price > minPrice)
                .ToListAsync();

            return _mapper.Map<ComputerResponse>(computer);
        }

        public async Task<ComputerResponse> GetComputerMinMaxPrice(int min, int max)
        {
            var computer = await _appDbContext.Computers
                .Where(computer => computer.Price > min && computer.Price < max)
                .ToListAsync();

            return _mapper.Map<ComputerResponse>(computer);
        }

        public async Task<ComputerResponse> DeleteComputerById(int id)
        {
            Computer computer = await _appDbContext.Computers.FindAsync(id);

            ComputerResponse computerResponse = _mapper.Map<ComputerResponse>(computer);

            _appDbContext.Computers.Remove(computer);

            await _appDbContext.SaveChangesAsync();

            return computerResponse;
        }

        public async Task<ComputerResponse> UpdateComputer(int id, EditComputerRequest computerReq)
        {
            var computer = await _appDbContext.Computers.FindAsync(id);

            computer.Type = computerReq.Type ?? computer.Type;
            computer.model = computerReq.Model ?? computer.model;
            computer.Price = (int)(computerReq.Price ?? computerReq.Price);

            _appDbContext.Computers.Update(computer);
            await _appDbContext.SaveChangesAsync();

            return _mapper.Map<ComputerResponse>(computer);
        }

        public async Task<bool> IsDuplicatedAsync(AddComputerRequest computerReq)
        {
            return await _appDbContext.Computers.AnyAsync(c  => c.model == computerReq.Model &&
                                                                c.Type ==  computerReq.Type);
        }

        public async Task<ComputerResponse> FindComputerIdAsync (int id)
        {
            var computer = await _appDbContext.Computers.FirstOrDefaultAsync(computer => computer.Id == id);

            return _mapper.Map<ComputerResponse>(computer);
        }
    }
}
