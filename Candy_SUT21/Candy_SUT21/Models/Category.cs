namespace Candy_SUT21.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Candy> Candies { get; set; }
    }
}
