namespace CarMarket.Models.Requests
{
    public class GetAllCarsByBrandRequest
    {
        public int BrandId { get; set; }

        public DateTime DateAfter { get; set; }
    }
}