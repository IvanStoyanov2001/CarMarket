using CarMarket.Models.Models;
using CarMarket.Models.Models.Users;

namespace CarMarket.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Brand> BrandsData
            = new List<Brand>()
            {
                new Brand()
                {
                    Id = 1,
                    Name = "Skoda",
                    StartupDay = DateTime.Now
                },
                new Brand()
                {
                    Id = 2,
                    Name = "Opel",
                    StartupDay = DateTime.Now
                },
                new Brand()
                {
                    Id = 3,
                    Name = "Nissan",
                    StartupDay = DateTime.Now
                },
            };

        public static List<Car> CarData
            = new List<Car>()
            {
                new Car()
                {
                    Id = 1,
                  ModelName = "Octavia",
                  BrandId = 1,
                  ReleaseDate = new DateTime(2004,03,10)
                },
                new Car()
                {
                    Id = 4,
                    ModelName = "Kamiq",
                    BrandId = 1,
                    ReleaseDate = new DateTime(2017,04,19)
                },
                new Car()
                {
                    Id = 2,
                    ModelName = "Astra",
                    BrandId = 2,
                    ReleaseDate = new DateTime(1998,04,15)
                },
                new Car()
                {
                    Id = 3,
                  ModelName = "Vectra",
                    BrandId = 2,
                    ReleaseDate = new DateTime(2008,08,01)
                },
            };
    }
}
