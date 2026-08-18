using Blueprint41;
using models.CardSets;
using DeckBuilder.Generated.Query;

using CardSetEntity = DeckBuilder.Generated.Manipulation.CardSet;

namespace webapi.Nodes.CardSets.Repository;

public class CardSetRepository
{
    public CardSet? ReadCardSet(Guid id)
    {
        return CardSetEntity.Load(id.ToString());
    }

    public List<CardSet> ReadAllCardSet()
    {
        List<CardSet> cardSets = [];
        using (Transaction.Begin())
        {
            var query = Transaction.CompiledQuery
                .Match
                (
                    Blueprint41.Query.Node.CardSet.Alias(out var cardSet)
                )
                .Return(cardSet)
                .Compile();

            cardSet = CardSetEntity.LoadWhere(query).ConvertAll<CardSet>(cs => cs!);
        }

        return cardSets;
    }
}