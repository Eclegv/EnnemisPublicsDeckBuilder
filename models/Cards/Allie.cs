using System;
using System.Collections.Generic;
using models.Tokens;

namespace models.Cards;

public class Allie : Card
{
    public List<Token> Costs { get; set; } = [];
    
    public Allie()
    {
        Type = GetType().Name;
    }
}
