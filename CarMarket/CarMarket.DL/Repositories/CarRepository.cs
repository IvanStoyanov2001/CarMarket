using CarMarket.DL.Interfaces;
using CarMarket.Models.Models;
using CarMarket.DL.MemoryDb;

namespace CarMarket.DL.Repositories
{
    public class CarRepository : ICarRepository
    {
        public List<Car> GetAll()
        {
            return InMemoryDb.CarData;
        }

        public Car GetById(int id)
        {
            return InMemoryDb.CarData
                .First(a => a.Id == id);
        }

        public void Add(Car brand)
        {
            InMemoryDb.CarData.Add(brand);
        }

        public void Remove(int id)
        {
            var brand = GetById(id);
            InMemoryDb.CarData.Remove(brand);
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return InMemoryDb.CarData
                .Where(b => b.BrandId == brandId)
                .ToList();
        }
    }
}
