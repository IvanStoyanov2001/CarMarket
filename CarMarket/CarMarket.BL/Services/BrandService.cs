using CarMarket.BL.Interfaces;
using CarMarket.DL.Interfaces;
using CarMarket.Models.Models.Users;

namespace CarMarket.BL.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public List<Brand> GetAll()
        {
            return _brandRepository.GetAll();
        }

        public Brand GetById(int id)
        {
            if (id > 50000) return null;

            return _brandRepository.GetById(id);
        }

        public void Add(Brand brand)
        {
            _brandRepository.Add(brand);
        }

        public void Remove(int id)
        {
            _brandRepository.Remove(id);
        }
    }
}