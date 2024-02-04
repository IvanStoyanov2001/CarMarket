using CarMarket.Models.Requests;
using CarMarket.Models.Responses;

namespace CarMarket.BL.Interfaces
{
    public interface ILibraryService
    {
        int CheckCarCount(int input);
        GetAllCarsByBrandResponse?
            GetAllCarsByBrandAfterReleaseDate(
                GetAllCarsByBrandRequest request);

    }
}