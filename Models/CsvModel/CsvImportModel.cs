using CsvHelper.Configuration.Attributes;

namespace LearnCSVHelper.Models.CsvModel
{
    public class CategoryCsvImportModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
    public class ProductCsvImportModel
    {
        [Index(1)]
        public string Name { get; set; } = string.Empty;
        [Index(2)]
        public string Description { get; set; } = string.Empty;
        [Index(3)]
        public string Category {  get; set; } = string.Empty;
        [Index(4)]
        public double Price { get; set; }
        [Index(5)]
        public int Stok { get; set; }
        [Index(6)]
        public DateTime DateField { get; set; }
    }
    public class BookingCsvImportModel
    {
        [Name("Product Name")]
        public string ProductName { get; set; } = string.Empty;
        [Name("Amount")]
        public int Amount {  get; set; }
        [Name("Bought At")]
        public DateTime BoughtAt {  get; set; }
        [Name("Bought By")]
        public string BoughtBy { get; set; } = string.Empty;
    }
}
