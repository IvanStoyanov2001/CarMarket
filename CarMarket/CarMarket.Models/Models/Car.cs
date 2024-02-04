namespace CarMarket.Models.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string ModelName { get; set; } = string.Empty;

        public int BrandId { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
