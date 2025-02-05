using computers_api.Computers.Models;
using computers_api.Computers.Repository;
using Microsoft.AspNetCore.Mvc;

namespace computers_api.Computers.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ComputerController : ControllerBase
    {
        private IComputerRepo _computerRepo;

        public ComputerController(IComputerRepo computerRepo)
        {
            _computerRepo = computerRepo;
        }

        [HttpGet]

        public async Task<ActionResult<List<Computer>>> GetComputerAsync()
        {
            var computer = await _computerRepo.GetComputersAsync();

            return Ok(computer);
        }
    }
}
