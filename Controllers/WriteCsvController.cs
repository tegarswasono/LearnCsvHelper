using CsvHelper.Configuration;
using CsvHelper;
using LearnCSVHelper.Helpers;
using LearnCSVHelper.Models.CsvModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace LearnCSVHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriteCsvController : ControllerBase
    {

        [HttpGet]
        [Route("category")]
        public IActionResult Category()
        {
            var records = new List<CategoryCsvExportModel>() 
            { 
                new () { Name = "Category 1", Description = "Desc 1" },
                new () { Name = "Category 2", Description = "Desc 2" },
                new () { Name = "Category 3", Description = "Desc 3" }
            };
            var result = CsvHelper1.ConvertListObjectToByteArray<CategoryCsvExportModel>(records);
            return File(result, "text/csv", "blabla.csv");
        }

        [HttpGet]
        [Route("category2")]
        public IActionResult Category2()
        {
            var records = new List<CategoryCsvExportModel2>()
            {
                new () { Name = "Category 1", Description = "Desc 1" },
                new () { Name = "Category 2", Description = "Desc 2" },
                new () { Name = "Category 3", Description = "Desc 3" }
            };
            var result = CsvHelper1.ConvertListObjectToByteArray<CategoryCsvExportModel2>(records);
            return File(result, "text/csv", "blabla.csv");
        }
    }
}
