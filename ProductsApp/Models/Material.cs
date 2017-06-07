namespace ProductsApp.Models
{
    public class Material
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public QualityStatus Quality { get; set; }
    }

    public enum QualityStatus
    {
        Primeum,
        Good,
        Fair,
        Flaw,
        Dilapidated
    }
}