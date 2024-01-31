using GimnasioApp.Entities;
using GimnasioApp.Repositories.Interfaces;
using GimnasioApp.Shared;
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

        [HttpPost]
        public async Task<IActionResult>Post(MembresiaDto request)
        {
            var membresia = new Membresia
            {
                Descripcion = request.Descripcion,
                PrecioMembresia = request.PrecioMembresia,
                Observacion = request.Observacion
            };
            await _repository.AddAsync(membresia);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult>Get(int id)
        {
            var membresia = await _repository.FindAsync(id);
            if (membresia == null)
            {
                return NotFound();
            }
            return Ok(membresia);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult>Put(int id, MembresiaDto request)
        {
            var membresia = await _repository.FindAsync(id);
            if (membresia == null)
            {
                return NotFound();
            }
            membresia.Descripcion = request.Descripcion;
            membresia.PrecioMembresia=request.PrecioMembresia;
            membresia.Observacion = request.Observacion;
            await _repository.UpdateAsync();
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult>Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return Ok();
        }

        
    }
}
