using System.Threading.Tasks;
using Backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers {
    [ApiController]
    [Route ("user")]
    public class UserController : ControllerBase {
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get () {
            return Ok (new { hola = "hola" });
        }

        [HttpPost ("login")]
        public async Task<IActionResult> Login ([FromBody] Login loginDto) {
            if (!ModelState.IsValid)
                return StatusCode (406, ModelState);
            return Ok ("Hola");
        }

    }
}