using Microsoft.EntityFrameworkCore;
using RestaurantApi.Models;
using RestaurantApi.Models.Dtos;
using RestaurantApi.Services.IRestaurant;

namespace RestaurantApi.Services
{
    public class TermekService : ITermek
    {
        private readonly RestaurantContext _context;
        ResponseDto responseDto = new ResponseDto();
        public TermekService(RestaurantContext conetxt)
        {
            _context = conetxt;
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
