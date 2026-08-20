using System;

namespace models.CardSets;

public class CardSet
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int CardCount { get; set; }
}
