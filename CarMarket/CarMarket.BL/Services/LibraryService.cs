using CarMarket.BL.Interfaces;
using CarMarket.Models.Requests;
using CarMarket.Models.Responses;
using CarMarket.BL.Interfaces;

namespace CarMarket.BL.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IBrandService _brandService;
        private readonly ICarService _carService;

        public LibraryService(
            IBrandService brandService,
            ICarService carService)
        {
            _brandService = brandService;
            _carService = carService;
        }

        public int CheckCarCount(int input)
        {
            if (input < 0) return 0;

            var carCount = _carService.GetAll();

            return carCount.Count + input;
        }


        public GetAllCarsByBrandResponse?
            GetAllCarsByBrandAfterReleaseDate(
                GetAllCarsByBrandRequest request)
        {
            var response = new GetAllCarsByBrandResponse
            {
                Brand = _brandService
                    .GetById(request.BrandId),
                Cars = _carService
                    .GetAllByBrandAfterReleaseDate(
                        request.BrandId,
                        request.DateAfter)
            };

            return response;
        }
    }
}