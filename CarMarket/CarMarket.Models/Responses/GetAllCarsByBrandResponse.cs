using CarMarket.Models.Models;
using CarMarket.Models.Models.Users;

namespace CarMarket.Models.Responses
{
    public class GetAllCarsByBrandResponse
    {
        public Brand Brand { get; set; }

        public List<Car> Cars { get; set; }
    }
}