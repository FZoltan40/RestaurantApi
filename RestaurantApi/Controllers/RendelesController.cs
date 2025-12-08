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
            var response = await _rendeles.GetAllRendeles();
            if (response != null)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }


        [HttpGet("withcard")]
        public async Task<ActionResult> GetAllRendelesWithCard()
        {
            var response = await _rendeles.GetAllRendelesWithCard();
            if (response != null)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

        [HttpGet("withfood")]
        public async Task<ActionResult> GetAllRendelesWithFood()
        {
            var response = await _rendeles.GetAllRendelesWithFood();
            if (response != null)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

    }
}
