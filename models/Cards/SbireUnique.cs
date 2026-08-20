using System;

namespace models.Cards;

public class SbireUnique : Sbire
{
    public SbireUnique()
    {
        Type = GetType().Name;
    }
}
