using CarMarket.BL.Interfaces;
using CarMarket.Models.Requests;
using CarMarket.Models.Responses;
using CarMarket.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {

        private readonly ILibraryService _libraryService;
        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }
        [HttpPost("GetAllCarsByBrandAndDate")]
        public GetAllCarsByBrandResponse?
            GetAllCarsByBrandAndDate([FromBody]
                GetAllCarsByBrandRequest request)
        {
            return _libraryService
                .GetAllCarsByBrandAfterReleaseDate(request);
        }
        [HttpPost("SomeEndpoint")]
        public string GetSomeData([FromBody] SomeRequest request)
        {
            return "Ok";
        }

    }
}