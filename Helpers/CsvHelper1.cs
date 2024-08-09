using CsvHelper;
using CsvHelper.Configuration;
using LearnCSVHelper.Models.CsvModel;
using System.Globalization;

namespace LearnCSVHelper.Helpers
{
    public static class CsvHelper1
    {
        public static List<T> ConvertFileToListObject<T>(IFormFile file) where T : class
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
        public static byte[] ConvertListObjectToByteArray<T>(List<T> records)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };
            var memoryStream = new MemoryStream();
            var writer = new StreamWriter(memoryStream);
            var csv = new CsvWriter(writer, config);

            csv.WriteRecords(records);
            csv.Flush();
            memoryStream.Position = 0;

            var csvByteArray = memoryStream.ToArray();
            csv.Dispose();
            writer.Dispose();
            memoryStream.Dispose();

            return csvByteArray;
        }
    }
}
