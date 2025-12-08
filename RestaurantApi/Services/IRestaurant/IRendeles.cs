namespace RestaurantApi.Services.IRestaurant
{
    public interface IRendeles    {
        Task<object> GetAllRendeles();
        Task<object> GetAllRendelesWithCard();
        Task<object> GetAllRendelesWithFood();
    }
}
