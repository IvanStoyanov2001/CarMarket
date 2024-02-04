using CarMarket.BL.Interfaces;
using CarMarket.Models.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace CarMarket.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("GetAll")]
        public List<Brand> GetAll()
        {
            return _brandService.GetAll();
        }

        [HttpGet("GetById")]
        public Brand GetById(int id)
        {
            return _brandService.GetById(id);
        }

        [HttpPost]
        public void Add([FromBody] Brand brand)
        {
            _brandService.Add(brand);
        }

        [HttpDelete]
        public void DeleteById(int id)
        {
            _brandService.Remove(id);
        }
    }
}
