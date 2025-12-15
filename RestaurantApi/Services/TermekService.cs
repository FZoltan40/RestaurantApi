using Microsoft.EntityFrameworkCore;
using RestaurantApi.Models;
using RestaurantApi.Models.Dtos;
using RestaurantApi.Services.IRestaurant;

namespace RestaurantApi.Services
{
    public class TermekService : ITermek
    {
        private readonly RestaurantContext _context;
        private readonly ResponseDto responseDto;
        public TermekService(RestaurantContext context, ResponseDto responseDTO)
        {
            _context = context;
            responseDto = responseDTO;
        }
        public async Task<object> GetTermek()
        {
            try
            {
                var response = await _context.Termekeks
                    .Select(x=> new { x.Etel, x.Ar})
                    .ToListAsync();

                responseDto.Message = "Sikeres lekérdezés";
                responseDto.Result = response;

                return responseDto;
            }
            catch (Exception ex)
            {

                responseDto.Message = ex.Message;
                responseDto.Result = null;

                return responseDto;
            }
        }
    }
}
