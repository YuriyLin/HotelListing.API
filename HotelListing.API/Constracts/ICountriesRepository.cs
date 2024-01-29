using HotelListing.API.Data;

namespace HotelListing.API.Constracts
{
    public interface ICountriesRepository:IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
