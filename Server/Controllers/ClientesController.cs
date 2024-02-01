using GimnasioApp.Entities;
using GimnasioApp.Repositories.Interfaces;
using GimnasioApp.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GimnasioApp.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteRepository _repository;

        public ClientesController(IClienteRepository repository) 
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult>Get()
        {
            return Ok(await _repository.ListAsync());
        }

        [HttpPost]
        public async Task<IActionResult>Post(ClienteDto request)
        {
            var cliente = new Cliente
            {
                Nombres = request.Nombres,
                ApellidoP = request.ApellidoP,
                ApellidoM = request.ApellidoM,
                FechaNacimiento = request.FechaNacimiento,
                Genero = request.Genero,
                DNI = request.DNI,
                Direccion = request.Direccion,
                Correo = request.Correo,
                Telefono = request.Telefono,
                TelefonoEmergencia = request.TelefonoEmergencia,
                EstadoCivil = request.EstadoCivil

            };
            await _repository.AddAsync(cliente);
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult>Get(int id)
        {
            var cliente = await _repository.FindAsync(id);
            if(cliente ==null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult>Put(int id, ClienteDto request)
        {
            var cliente = await _repository.FindAsync(id);
            if(cliente ==null)
            {
                return NotFound();
            }
            cliente.Nombres = request.Nombres;
            cliente.ApellidoP = request.ApellidoP;
            cliente.ApellidoM = request.ApellidoM;
            cliente.FechaNacimiento = request.FechaNacimiento;
            cliente.Genero = request.Genero;
            cliente.DNI = request.DNI;
            cliente.Direccion = request.Direccion;
            cliente.Correo = request.Correo;
            cliente.Telefono = request.Telefono;
            cliente.TelefonoEmergencia = request.TelefonoEmergencia;
            cliente.EstadoCivil = request.EstadoCivil;
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
