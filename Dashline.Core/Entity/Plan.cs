namespace Dashline.Core.Entity;

public class Plan
{
    public int ID { get; set; }
    public int PilotID { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public string Description { get; set; } = String.Empty;
    public double Distance { get; set; }
    public string Origin { get; set; } = null!;
    public string Destination { get; set; } = null!;
    public string AdditionalWaypoints { get; set; } = string.Empty;

    public Pilot Pilot { get; set; } = null!;
}
