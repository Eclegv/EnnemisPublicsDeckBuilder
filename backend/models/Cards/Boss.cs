using System;

namespace models.Cards;

public class Boss : Card
{
    public Boss()
    {
        Type = GetType().Name;
    }
}
