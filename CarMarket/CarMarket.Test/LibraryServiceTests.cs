using CarMarket.BL.Services;
using CarMarket.DL.Interfaces;
using CarMarket.DL.Repositories;
using CarMarket.Models.Models;
using CarMarket.Models.Models.Users;
using CarMarket.Models.Requests;
using Moq;

namespace CarMarket.Tests
{
    public class LibraryServiceTests
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

        [Fact]
        public void CheckCarCount_OK()
        {
            //setup
            var input = 10;
            var expectedCount = 14;

            var mockedCarRepository =
                new Mock<ICarRepository>();

            mockedCarRepository.Setup(
                    x => x.GetAll())
                .Returns(CarData);

            //inject
            var carService =
                new CarService(mockedCarRepository.Object);
            var brandService =
                new BrandService(new BrandRepository());
            var service = new LibraryService(
                brandService, carService);

            //Act
            var result = service.CheckCarCount(input);

            //Assert
            Assert.Equal(expectedCount, result);

        }

        [Fact]
        public void CheckCarCount_NegativeInput()
        {
            //setup
            var input = -10;
            var expectedCount = 0;

            var mockedCarRepository =
                new Mock<ICarRepository>();

            mockedCarRepository.Setup(
                    x => x.GetAll())
                .Returns(CarData);

            //inject
            var carService =
                new CarService(mockedCarRepository.Object);
            var brandService =
                new BrandService(new BrandRepository());
            var service = new LibraryService(
                brandService, carService);

            //Act
            var result = service.CheckCarCount(input);

            //Assert
            Assert.Equal(expectedCount, result);

        }

        [Fact]
        public void GetAllCarsByBrandAfterReleaseDate_OK()
        {
            //setup
            var request = new GetAllCarsByBrandRequest
            {
                BrandId = 1,
                DateAfter = new DateTime(2018, 2, 4)
            };
            var expectedCount = 2;

            var mockedCarRepository =
                new Mock<ICarRepository>();
            var mockedBrandRepository =
                new Mock<IBrandRepository>();

            mockedCarRepository.Setup(
                    x =>
                        x.GetAllByBrand(request.BrandId))
                .Returns(CarData
                    .Where(b => b.BrandId == request.BrandId)
                    .ToList());

            mockedBrandRepository.Setup(
                    x =>
                        x.GetById(request.BrandId))
                .Returns(BrandsData!
                    .FirstOrDefault(a =>
                        a.Id == request.BrandId)!);

            //inject
            var carService =
                new CarService(mockedCarRepository.Object);
            var brandService =
                new BrandService(mockedBrandRepository.Object);
            var service = new LibraryService(
                brandService, carService);

            //Act
            var result =
                service.GetAllCarsByBrandAfterReleaseDate(request);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(expectedCount, result!.Cars.Count);
            Assert.Equal(request.BrandId, result.Brand.Id);

        }
    }
}