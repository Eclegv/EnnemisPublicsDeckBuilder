using System;
using CardModel = models.Cards.Card;
using AllieModel = models.Cards.Allie;

namespace DeckBuilder.Generated.Manipulation;

public partial class Allie
{
    public CardModel ToModelCard()
    {
        return new AllieModel
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
