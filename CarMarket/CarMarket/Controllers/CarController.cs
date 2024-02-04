using CarMarket.BL.Interfaces;
using CarMarket.Models.Models;
using CarMarket.Models.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace CarMarket.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetAll")]
        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }

        [HttpGet("GetById")]
        public Car GetById(int id)
        {
            return _carService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Car car)
        {
            _carService.Add(car);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _carService.Remove(id);
        }
    }
}