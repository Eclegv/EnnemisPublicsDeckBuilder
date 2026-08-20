using System.ComponentModel.DataAnnotations;

namespace webapi.Nodes.CardSets.Input;

public class ReadCardsFromCardSetInput(Guid id)
{
	[Required]
    public Guid CardSetId { get; set; } = id;
}