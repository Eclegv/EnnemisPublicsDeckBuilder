using System;

namespace models.Cards;

public class Action : Card
{
    public Action()
    {
        Type = GetType().Name;
    }
}
