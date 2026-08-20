using System;
using CardModel = models.Cards.Card;
using SbireModel = models.Cards.Sbire;
using TokenModel = models.Tokens.Token;

namespace DeckBuilder.Generated.Manipulation;

public partial class Sbire
{
    public CardModel ToModelCard()
    {
        Console.WriteLine();

        return new SbireModel
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
            Values = this.Tokens.ToList().ConvertAll<TokenModel>(tk => tk!)
        };
    }
}