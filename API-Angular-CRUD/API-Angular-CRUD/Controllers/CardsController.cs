using API_Angular_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Angular_CRUD.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : Controller
    {
        private readonly CardsDbContext _cardContext;

        public CardsController(CardsDbContext cardsContext)
        {
            _cardContext = cardsContext;
        }

        //Get All Cards
        [HttpGet]
        public async Task<IActionResult> GetAllCards()
        {
            var cards = await _cardContext.Cards.ToListAsync();
            return Ok(cards);
        }

        //Get Single Card
        [HttpGet]
        [Route("{id:guid}")]
        [ActionName("GetSingleCard")]
        public async Task<IActionResult> GetSingleCard([FromRoute]Guid id)
        {
            var card = await _cardContext.Cards.FirstOrDefaultAsync(c => c.ID == id);
            if (card != null)
            {
                return Ok(card);
            }
            return NotFound("Couldn't find a card with the requested id!");
        }

        //Add Card
        [HttpPost]
        public async Task<IActionResult> AddCard([FromBody]Card card)
        {
            card.ID = Guid.NewGuid();
            await _cardContext.Cards.AddAsync(card);
            await _cardContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSingleCard), new {id = card.ID}, card);
        }

        //Update Card
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateCard([FromRoute]Guid id, Card card)
        {
            var cardToUpdate = await _cardContext.Cards.FirstOrDefaultAsync(c => c.ID == id);
            if (cardToUpdate != null)
            {
                cardToUpdate.HolderName = card.HolderName;
                cardToUpdate.CardNumber = card.CardNumber;
                cardToUpdate.ExpireMonth = card.ExpireMonth;
                cardToUpdate.ExpireYear = card.ExpireYear;
                cardToUpdate.CVC = card.CVC;

                await _cardContext.SaveChangesAsync();
                return Ok(cardToUpdate);
            }
            return NotFound("No card with that id was found to be updated!");
        }

        //Delete Card
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteCard([FromRoute]Guid id)
        {
            var cardToDelete = await _cardContext.Cards.FirstOrDefaultAsync(c => c.ID == id);
            if (cardToDelete != null)
            {
                _cardContext.Cards.Remove(cardToDelete);
                await _cardContext.SaveChangesAsync();
                return Ok(cardToDelete);
            }
            return NotFound("No card with that id was found to be deleted!");
       }
    }
}