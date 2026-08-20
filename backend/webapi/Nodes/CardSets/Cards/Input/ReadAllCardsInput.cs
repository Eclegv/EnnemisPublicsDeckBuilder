using System.ComponentModel.DataAnnotations;

namespace webapi.Nodes.Cards.Input;

public class ReadAllCardsInput(Guid id)
{

	[Required]
    public Guid CardSetId { get; set; } = id;
}