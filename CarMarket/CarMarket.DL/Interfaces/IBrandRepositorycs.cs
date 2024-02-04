using CarMarket.Models.Models.Users;

namespace CarMarket.DL.Interfaces
{
    public interface IBrandRepository
    {
        List<Brand> GetAll();

        Brand GetById(int id);

        void Add(Brand brand);

        void Remove(int id);    
    }
}