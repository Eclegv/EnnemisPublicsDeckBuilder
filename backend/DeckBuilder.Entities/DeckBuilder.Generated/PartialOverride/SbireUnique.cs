using System;
using CardModel = models.Cards.Card;
using SbireUniqueModel = models.Cards.SbireUnique;

namespace DeckBuilder.Generated.Manipulation;

public partial class SbireUnique
{
    public CardModel ToModelCard()
    {
        return new SbireUniqueModel
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