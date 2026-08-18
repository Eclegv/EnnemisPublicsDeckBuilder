using Microsoft.AspNetCore.Mvc;
using models.Cards;
using models.CardSets;
using AllieEntity = DeckBuilder.Generated.Manipulation.Allie;

namespace webapi.Nodes.CardSets.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardSetController : ControllerBase
    {
        [HttpGet("{id}/cards")]
        public ActionResult<List<Card>> ReadCardsFromCardSet(string id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public ActionResult<List<CardSet>> ReadAllCardSet()
        {
            throw new NotImplementedException();
        }
    }
}
