using CarMarket.BL.Interfaces;
using CarMarket.DL.Interfaces;
using CarMarket.Models.Models;

namespace CarMarket.BL.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public List<Car> GetAll()
        {
            return _carRepository.GetAll();
        }

        public Car GetById(int id)
        {
            if (id <= 0) return new Car();

            return _carRepository.GetById(id);
        }

        public void Add(Car car)
        {
            _carRepository.Add(car);
        }

        public void Remove(int id)
        {
            _carRepository.Remove(id);
        }

        public List<Car> GetAllByBrandAfterReleaseDate
            (int brandId, DateTime afterDate)
        {
            var result =
                _carRepository.GetAllByBrand(brandId);

            return result
                .Where(b => b.ReleaseDate >= afterDate)
                .ToList();
        }
    }
}