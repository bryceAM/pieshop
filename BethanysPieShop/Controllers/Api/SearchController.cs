using BethanysPieShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers.Api
{
    // ASP.NET will replace [controller] with Search, since this is in the file SearchController
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IPieRepository _pieRepository;

        public SearchController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

        }
    }
}
