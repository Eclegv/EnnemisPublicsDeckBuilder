using System;

namespace models.Cards;

public class Valise : Card
{
    public Valise()
    {
        Type = GetType().Name;
    }
}
