using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace LearnCSVHelper.Helpers
{
    public static class CsvHelper1
    {
        public static List<T> ConvertToListObject<T>(IFormFile file) where T : class
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };
            using (var reader = new StreamReader(file.OpenReadStream()))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<T>().ToList();
                return records;
            }
        }
    }
}
