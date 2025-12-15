using RestaurantApi.Models;
using RestaurantApi.Models.Dtos;
using RestaurantApi.Services.IRestaurant;

namespace RestaurantApi.Services
{
    public class KapcsoloService : IKapcsolo
    {
        private readonly RestaurantContext _context;
        private readonly ResponseDto responseDto;
        public KapcsoloService(RestaurantContext context, ResponseDto responseDTO)
        {
            _context = context;
            responseDto = responseDTO;
        }

        public async Task<object> PostNewRelation(AddRelationDto addRelationDto)
        {
            try
            {
                var relation = new Kapcsolo 
                { 
                    RendelesId = addRelationDto.RendelesId,
                    TermekekId = addRelationDto.TermekekId
                };

                if (relation != null)
                {
                    await _context.Kapcsolos.AddAsync(relation);
                    await _context.SaveChangesAsync();

                    responseDto.Message = "Sikeres összerendelés.";
                    responseDto.Result = relation;

                    return responseDto;
                }

                responseDto.Message = "Sikertelen összerendelés.";
                responseDto.Result = relation;

                return responseDto;
            }
            catch (Exception ex)
            {
                responseDto.Message = ex.Message;
                responseDto.Result = ex.Data;

                return responseDto;
            }
        }
    }
}
