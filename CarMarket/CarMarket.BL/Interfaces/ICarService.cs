using CarMarket.Models.Models;

namespace CarMarket.BL.Interfaces
{
    public interface ICarService
    {
        List<Car> GetAll();

        Car GetById(int id);

        void Add(Car car);

        void Remove(int id);

        public List<Car>
           GetAllByBrandAfterReleaseDate(
               int brandId,
               DateTime afterDate);
    }
}