using System;

namespace models.Cards;

public class Card
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? BaseEffect { get; set; }
    public string? ReactionEffect { get; set; }
    public string? EnteringEffect { get; set; }
    public string? LeavingEffect { get; set; }
    public string? ActivationEffect { get; set; }
    public string? MandatoryActivationEffect { get; set; }
    public string? PermanentEffect { get; set; }
    public string? LoosingEffect { get; set; }
    public string? Lore { get; set; }
}
