using System;

namespace models.Cards;

public class Reaction : Card
{
    public Reaction()
    {
        Type = GetType().Name;
    }
}
