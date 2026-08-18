using System;
using CardSetModel = models.CardSets.CardSet;

namespace DeckBuilder.Generated.Manipulation;

public partial class CardSet
{
    public static implicit operator CardSetModel?(CardSet? cardSet)
    {
        if(cardSet is null)
            return null;

        return new CardSetModel()
        {
            Id = Guid.Parse(cardSet.Id),
            Name = cardSet.Name
        };
    }
}