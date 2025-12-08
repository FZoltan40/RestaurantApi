using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Models;
using RestaurantApi.Services.IRestaurant;

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TermekController : ControllerBase
    {
        private readonly ITermek _termek;
        public TermekController(ITermek termek)
        {
            _termek = termek;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllTermek()
        {
            var response = await _termek.GetTermek();
            if (response != null)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }
    }
}
