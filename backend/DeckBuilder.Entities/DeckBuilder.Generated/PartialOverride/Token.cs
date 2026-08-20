using System;
using TokenModel = models.Tokens.Token;

namespace DeckBuilder.Generated.Manipulation;

public partial class Token
{
    public static implicit operator TokenModel?(Token? token)
    {
        if(token is null)
            return null;

        return new TokenModel()
        {
            Name = token.Name,
        };
    }
}