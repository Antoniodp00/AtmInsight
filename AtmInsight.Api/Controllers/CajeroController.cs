using AtmInsight.Application.Services;
using AtmInsight.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AtmInsight.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]// Requiere autenticación para acceder a las acciones del controlador(Admin)
    public class CajeroController : ControllerBase
    {
        private readonly CajeroService _cajeroService;

        public CajeroController(CajeroService cajeroService)
        {
            _cajeroService = cajeroService;
        }

        // GET: api/cajero
        // Solo los usuarios con rol "ADMIN" o "Tecnico" pueden acceder a esta acción
        [HttpGet]
        [Authorize(Roles = "ADMIN, Tecnico")]
        public async Task<IActionResult> GetCajeros()
        {
            var cajeros = await _cajeroService.ObtenerTodosAsync();
            return Ok(cajeros);
        }

        // GET: api/cajero/{id}
        [HttpGet("{id}")]
        [Authorize(Roles = "ADMIN, Tecnico")]
        public async Task<IActionResult> GetCajero(string id)
        {
            var cajero = await _cajeroService.ObtenerPorIdAsync(id);
            if (cajero == null) return NotFound();
            return Ok(cajero);
        }

        // POST: api/cajero
        // Solo los usuarios con rol "ADMIN" pueden crear un nuevo cajero
        [HttpPost]
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> CreateCajero([FromBody] Cajero cajero)
        {
            //Delegamos la lógica de guardado a la capa de Aplicación
            await _cajeroService.AgregarAsync(cajero);

            //Devolvemos la confirmación
            return CreatedAtAction(nameof(GetCajero), new { id = cajero.Id }, cajero);
        }


        // PUT: api/cajero/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> UpdateCajero(string id, [FromBody] Cajero cajero)
        {
            if (id != cajero.Id) return BadRequest("ID del cajero no coincide");
            await _cajeroService.ActualizarAsync(cajero);
            return NoContent();
        }

        // DELETE: api/cajero/{id}
        [HttpDelete("{id}")]
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> DeleteCajero(string id)
        {
            var cajero = await _cajeroService.ObtenerPorIdAsync(id);
            if (cajero == null) return NotFound();
            await _cajeroService.EliminarAsync(cajero);
            return NoContent();
        }
    }
}
