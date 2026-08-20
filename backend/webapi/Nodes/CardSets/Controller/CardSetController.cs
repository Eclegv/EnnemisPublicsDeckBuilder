using Microsoft.AspNetCore.Mvc;
using models.Cards;
using models.CardSets;
using webapi.Nodes.CardSets.Service;
using AllieEntity = DeckBuilder.Generated.Manipulation.Allie;

namespace webapi.Nodes.CardSets.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardSetController : ControllerBase
    {
        private readonly CardSetService _cardSetService;

        public CardSetController(CardSetService cardSetService)
        {
            _cardSetService = cardSetService;
        }

        [HttpGet("{id}/cards")]
        public ActionResult<List<Card>> ReadCardsFromCardSet(string id)
        {
            bool isParsed = Guid.TryParse(id, out Guid cardSetId);
            if(!isParsed)
                return BadRequest("Invalid ID - Should be GUID");

            return Ok(_cardSetService.ReadCardsFromCardSet(new(cardSetId)));
        }

        [HttpGet]
        public ActionResult<List<CardSet>> ReadAllCardSet()
        {
            return Ok(_cardSetService.ReadAllCardSet());
        }
    }
}
