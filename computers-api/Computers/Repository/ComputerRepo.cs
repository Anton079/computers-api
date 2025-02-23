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

        public async Task<ComputerResponse> CreateComputerAsync (ComputerRequest computerReq)
        {
            Computer computer = _mapper.Map<Computer>(computerReq);

            _appDbContext.Computers.Add(computer);

            await _appDbContext.SaveChangesAsync();

            ComputerResponse response = _mapper.Map<ComputerResponse>(computer);

            return response;
        }
    }
}
