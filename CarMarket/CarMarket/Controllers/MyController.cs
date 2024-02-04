using CarMarket.BL.Interfaces;
using CarMarket.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Car2Controller : ControllerBase
    {
        private readonly ICarService _carService;

        public Car2Controller(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetCarById")]
        public Car GetCarById(int id)
        {
            return _carService.GetById(id);
        }

        [HttpGet("GetAllCars")]
        public List<Car> GetAllCars()
        {
            return _carService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Car car)
        {
            _carService.Add(car);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _carService.Remove(id);
        }

    }
}