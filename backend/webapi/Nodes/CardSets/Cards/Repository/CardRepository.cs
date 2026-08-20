using Blueprint41;
using models.Cards;
using webapi.Nodes.Cards.Input;
using CardSetEntity = DeckBuilder.Generated.Manipulation.CardSet;
using ICardEntity = DeckBuilder.Generated.Manipulation.ICard;

namespace webapi.Nodes.Cards.Repository;

public class CardRepository
{
    public List<Card> ReadAllCardsFromCardSet(ReadAllCardsInput input)
    {
        using (Transaction.Begin())
        {
            CardSetEntity currentCardSet = CardSetEntity.Load(input.CardSetId.ToString());
            List<Card> cards = currentCardSet?.Cards?.Select(card => card.ToModelCard()).ToList();

            foreach(ICardEntity card in currentCardSet.Cards)
            {
                cards.Add(card.ToModelCard());
            }

            return cards;

            Transaction.Commit();
        }
    }
}