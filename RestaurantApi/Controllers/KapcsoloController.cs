using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantApi.Models.Dtos;
using RestaurantApi.Services.IRestaurant;

namespace RestaurantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KapcsoloController : ControllerBase
    {
        private readonly IKapcsolo kapcsolo;
        public KapcsoloController(IKapcsolo kapcsolo)
        {
            this.kapcsolo = kapcsolo;
        }

        [HttpPost]
        public async Task<ActionResult> PostRelation(AddRelationDto addRelationDto)
        {
            var requestResult = await kapcsolo.PostNewRelation(addRelationDto) as ResponseDto;
            var result = requestResult.Result as AddRelationDto;

            if (requestResult.Result != null)
            {
                return Ok(new { result.RendelesId , result.TermekekId });
            }
            else if (requestResult.Result == null)
            {
                return NotFound(requestResult);
            }
            else
            {
                return BadRequest(requestResult);
            }


           

        }
    }
}
