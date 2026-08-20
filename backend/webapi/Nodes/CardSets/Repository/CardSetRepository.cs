using Blueprint41;
using models.CardSets;
using DeckBuilder.Generated.Query;

using CardSetEntity = DeckBuilder.Generated.Manipulation.CardSet;

namespace webapi.Nodes.CardSets.Repository;

public class CardSetRepository
{
    public CardSet? ReadCardSet(Guid id)
    {
        using (Transaction.Begin())
        {
            return CardSetEntity.LoadById(id.ToString());
        }
    }

    public List<CardSet> ReadAllCardSet()
    {
        List<CardSet> cardSets = [];
        using (Transaction.Begin())
        {
            var query = Transaction.CompiledQuery
                .Match
                (
                    Node.CardSet.Alias(out var cardSet)
                )
                .Return(cardSet)
                .Compile();

            cardSets = CardSetEntity.LoadWhere(query).ConvertAll<CardSet>(cs => cs!);
        }

        return cardSets;
    }
}