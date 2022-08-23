namespace Candy_SUT21.Models
{
    public class Candy
    {
        public int CandyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public string Thumbnail { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public Category Category { get; set; }
    }
}
