namespace Candy_SUT21.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepo = new CategoryRepository();
        public IEnumerable<Candy> GetAllCandies => new List<Candy>
        {
            new Candy
            {   
                CandyID = 1, Name = "Assorted Hard Candy", Price = 4.95M, 
                Description = "Lorem ispum dollor sit amet, consectuer, adipiscing elit, sed do eisdmod tempus.", 
                Category = _categoryRepo.GetAllCategories.ToArray()[0], 
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/1/13/HardCandy.jpg", IsInStock = true, IsOnSale = false, 
                Thumbnail = "https://upload.wikimedia.org/wikipedia/commons/1/13/HardCandy.jpg"
            },
            new Candy
            {
                CandyID = 2, Name = "Assorted Chocolate Candy", Price = 5.95M,
                Description = "Lorem ispum dollor sit amet, consectuer, adipiscing elit, sed do eisdmod tempus.",
                Category = _categoryRepo.GetAllCategories.ToArray()[1],
                ImageURL = "https://en.wikipedia.org/wiki/Chocolate#/media/File:Chocolate_(blue_background).jpg", IsInStock = true, IsOnSale = false,
                Thumbnail = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Chocolate_%28blue_background%29.jpg/200px-Chocolate_%28blue_background%29.jpg"
            },
            new Candy
            {
                CandyID = 3, Name = "Assorted Fruit Candy", Price = 3.75M,
                Description = "Lorem ispum dollor sit amet, consectuer, adipiscing elit, sed do eisdmod tempus.",
                Category = _categoryRepo.GetAllCategories.ToArray()[2],
                ImageURL = "https://en.wikipedia.org/wiki/Fruit_Gushers#/media/File:Betty_Crocker_Fruit_Gushers_pieces_(cropped).jpg", IsInStock = true, IsOnSale = true,
                Thumbnail = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f7/Betty_Crocker_Fruit_Gushers_pieces_%28cropped%29.jpg/800px-Betty_Crocker_Fruit_Gushers_pieces_%28cropped%29.jpg"
            }
        };

        public IEnumerable<Candy> GetCandiesOnSale => throw new NotImplementedException();

        public Candy GetCandyByID(int candyID)
        {
            return GetAllCandies.FirstOrDefault(candy => candy.CandyID == candyID);
        }
    }
}
