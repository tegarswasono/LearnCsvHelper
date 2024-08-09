using LearnCSVHelper.Helpers;
using LearnCSVHelper.Models;
using LearnCSVHelper.Models.CsvModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnCSVHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadCsvController : ControllerBase
    {
        [HttpPost]
        [Route("category")]
        public IActionResult Category(IFormFile file)
        {
            var result = CsvHelper1.ConvertFileToListObject<CategoryCsvImportModel>(file);
            return Ok(result);
        }

        [HttpPost]
        [Route("product")]
        public IActionResult Product(IFormFile file)
        {
            var result = CsvHelper1.ConvertFileToListObject<ProductCsvImportModel>(file);
            return Ok(result);
        }

        [HttpPost]
        [Route("booking")]
        public IActionResult Booking(IFormFile file)
        {
            var result = CsvHelper1.ConvertFileToListObject<BookingCsvImportModel>(file);
            return Ok(result);
        }
    }
}
