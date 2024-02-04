using CarMarket.Models.Models;
using CarMarket.Models.Models.Users;

namespace CarMarket.DL.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAll();

        Car GetById(int id);

        void Add(Car car);

        void Remove(int id);

        List<Car> GetAllByBrand(int brandId);
    }
}
