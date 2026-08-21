namespace models.Cards;

public class Eclipse : Allie
{
    public string EclipseEffect { get; set; }

    public Eclipse()
    {
        Type = GetType().Name;
    }
}
