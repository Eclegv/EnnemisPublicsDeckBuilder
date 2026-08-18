using System;
using CardModel = models.Cards.Card;
using BossModel = models.Cards.Boss;

namespace DeckBuilder.Generated.Manipulation;

public partial class Boss
{
    public CardModel ToModelCard()
    {
        return new BossModel
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