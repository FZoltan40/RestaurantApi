using RestaurantApi.Models.Dtos;

namespace RestaurantApi.Services.IRestaurant
{
    public interface IKapcsolo
    {
        Task<object> PostNewRelation(AddRelationDto addRelationDto);
    }
}
