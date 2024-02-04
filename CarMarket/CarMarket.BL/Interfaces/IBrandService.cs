using CarMarket.Models.Models.Users;

namespace CarMarket.BL.Interfaces
{
    public interface IBrandService
    {
        List<Brand> GetAll();

        Brand GetById(int id);

        void Add(Brand brand);

        void Remove(int id);
    }
}