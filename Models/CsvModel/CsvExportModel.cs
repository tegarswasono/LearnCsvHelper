using CsvHelper.Configuration.Attributes;

namespace LearnCSVHelper.Models.CsvModel
{
    public class CategoryCsvExportModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
    public class CategoryCsvExportModel2
    {
        [Name("Name 2")]
        public string Name { get; set; } = string.Empty;
        [Name("Description 2")]
        public string Description { get; set; } = string.Empty;
    }
}
