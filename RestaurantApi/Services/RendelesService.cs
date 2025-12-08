using Microsoft.EntityFrameworkCore;
using RestaurantApi.Models;
using RestaurantApi.Models.Dtos;
using RestaurantApi.Services.IRestaurant;

namespace RestaurantApi.Services
{
    public class RendelesService : IRendeles
    {
		private readonly RestaurantContext _context;
		ResponseDto responseDto = new ResponseDto();
		public RendelesService(RestaurantContext conetxt)
		{
			_context = conetxt;
		}
        public async Task<object> GetAllRendeles()
        {
			try
			{
				var response = await _context.Rendeles.ToListAsync();
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

        public async Task<object> GetAllRendelesWithCard()
        {
            try
            {
                var response = await _context.Rendeles
                    .Where(x=>x.Fizetesimod == "Kártya")
                    .Select(x=> x.Id)
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
