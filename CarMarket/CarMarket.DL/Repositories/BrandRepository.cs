using CarMarket.DL.Interfaces;
using CarMarket.Models.Models.Users;
using CarMarket.DL.MemoryDb;

namespace CarMarket.DL.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        public List<Brand> GetAll()
        {
            return InMemoryDb.BrandsData;
        }

        public Brand GetById(int id)
        {
            return InMemoryDb.BrandsData
                .First(a => a.Id == id);
        }

        public void Add(Brand brand)
        {
            InMemoryDb.BrandsData.Add(brand);
        }

        public void Remove(int id)
        {
            var brand = GetById(id);
            InMemoryDb.BrandsData.Remove(brand);
        }
    }
}
