using computers_api.Computers.Dtos;
using computers_api.Computers.Exceptions;
using computers_api.Computers.Models;
using computers_api.Computers.Repository;
using computers_api.Computers.Service;
using Microsoft.AspNetCore.Mvc;

namespace computers_api.Computers.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ComputerController : ControllerBase
    {
        private IComputerCommandService _computerCommandService;
        private IComputerQueryService _computerQueryService;

        public ComputerController(IComputerCommandService computerCommandService, IComputerQueryService computerQueryService)
        {
            _computerCommandService = computerCommandService;
            _computerQueryService = computerQueryService;
        }

        [HttpGet("all")]

        public async Task<ActionResult<ComputerResponse>> GetComputerAsync()
        {
            var computer = await _computerQueryService.GetAllComputer();

            return Ok(computer);
        }


        [HttpPost("add")]

        public async Task<ActionResult<ComputerResponse>> CreateAsync([FromBody] AddComputerRequest computerReq)
        {
            try
            {
                ComputerResponse computerSaved = await _computerCommandService.CreateComputerAsync(computerReq);

                return Ok(computerSaved);
            }
            catch (ComputerExistException ex) { return BadRequest(ex.Message); }
        }

        //[HttpDelete("DeleteComputerByID")]

        //public async Task<ActionResult<ComputerResponse>> DeleteCar([FromQuery]DeleteComputerRequest computerReq)
        //{
        //    var car = await _computerCommandService.DeleteComputerById(computerReq);

        //    return Ok(car);
        //}

        [HttpPut("updateComputer")]

        public async Task<ActionResult<ComputerResponse>> UpdateComputerById([FromQuery]int id, [FromBody]EditComputerRequest computerReq)
        {
            ComputerResponse computer = await _computerCommandService.EditComputer(id, computerReq);
            return Ok(computer);
        }
    }
}
