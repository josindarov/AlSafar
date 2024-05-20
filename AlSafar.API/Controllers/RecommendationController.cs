using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecommendationController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;

        public RecommendationController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpGet]
        public IActionResult GetData()
        {
            // Combine the content root path with the relative path to the JSON file
            var filePath = Path.Combine(_env.ContentRootPath, "Data", "C:\\Users\\99899\\Desktop\\ML\\tarvel_top_7_place.json");
            
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound($"The file '{filePath}' was not found.");
            }

            var json = System.IO.File.ReadAllText(filePath);
            var data = JsonConvert.DeserializeObject<List<TravelPlace>>(json);

            return Ok(data);
        }
    }

    public class TravelPlace
    {
        public int Id { get; set; }
        public string PlaceName { get; set; }
        public string Category { get; set; }
        public double Rating { get; set; }
        public int Price { get; set; }
    }
}