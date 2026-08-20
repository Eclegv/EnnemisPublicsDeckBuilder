using System;
using System.Collections.Generic;
using models.Tokens;

namespace models.Cards;

public class Sbire : Card
{
    public List<Token> Values { get; set; } = [];

    public Sbire()
    {
        Type = GetType().Name;
    }
}
