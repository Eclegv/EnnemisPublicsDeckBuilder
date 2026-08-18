using System;
using CardModel = models.Cards.Card;
using ValiseModel = models.Cards.Valise;

namespace DeckBuilder.Generated.Manipulation;

public partial class Valise
{
    public CardModel ToModelCard()
    {
        return new ValiseModel
        {
            Id = Guid.Parse(this.Id),
            Name = this.Name,
            BaseEffect = this.BaseEffect,
            ReactionEffect = this.ReactionEffect,
            EnteringEffect = this.EnteringEffect,
            LeavingEffect = this.LeavingEffect,
            ActivationEffect = this.ActivationEffect,
            MandatoryActivationEffect = this.MandatoryActivationEffect,
            PermanentEffect = this.PermanentEffect,
            LoosingEffect = this.LoosingEffect,
            Lore = this.Lore,
        };
    }
}