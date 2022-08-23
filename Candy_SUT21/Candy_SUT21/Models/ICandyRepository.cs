namespace Candy_SUT21.Models
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandies { get; }
        IEnumerable<Candy> GetCandiesOnSale { get; }

        Candy GetCandyByID(int candyID);
    }
}
