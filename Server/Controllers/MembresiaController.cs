using GimnasioApp.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GimnasioApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembresiaController : ControllerBase
    {
        private readonly IMembresiaRepository _repository;

        public MembresiaController(IMembresiaRepository repository) 
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult>Get()
        {
            return Ok(await _repository.ListAsync());
        }






        
    }
}
