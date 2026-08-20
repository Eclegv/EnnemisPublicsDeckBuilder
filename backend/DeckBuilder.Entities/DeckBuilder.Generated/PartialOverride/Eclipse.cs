using System;
using System.Linq;
using CardModel = models.Cards.Card;
using EclipseModel = models.Cards.Eclipse;
using TokenModel = models.Tokens.Token;

namespace DeckBuilder.Generated.Manipulation;

public partial class Eclipse
{
    public CardModel ToModelCard()
    {
        return new EclipseModel
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
            EclipseEffect = this.EclipseEffect,
            Costs = this.Tokens.ToList().ConvertAll<TokenModel>(tk => tk!)
        };
    }
}