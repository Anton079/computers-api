﻿using AutoMapper;
using computers_api.Computers.Dtos;
using computers_api.Computers.Models;

namespace computers_api.Computers.Mapers
{
    public class ComputerMappingProfile:Profile
    {
        public ComputerMappingProfile()
        {
            CreateMap<EditComputerRequest, Computer>();
            CreateMap<AddComputerRequest, Computer>();
            CreateMap<DeleteComputerRequest, Computer>();
            CreateMap<Computer, ComputerResponse>();
        }
    }
}
