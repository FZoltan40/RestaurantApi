using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Services.IRestaurant;
using System.Runtime.InteropServices;

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RendelesController : ControllerBase
    {
        private readonly IRendeles _rendeles;
        public RendelesController(IRendeles rendeles)
        {
            _rendeles = rendeles;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllRendeles()
        {
            var rendelesek = await _rendeles.GetAllRendeles();
            if (rendelesek != null)
            {
                return Ok(rendelesek);
            }

            return BadRequest(rendelesek);
        }
    }
}
