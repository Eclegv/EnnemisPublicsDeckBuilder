using CardModel = models.Cards.Card;

namespace DeckBuilder.Generated.Manipulation;

public partial interface ICard
{
    public abstract CardModel ToModelCard();
}
