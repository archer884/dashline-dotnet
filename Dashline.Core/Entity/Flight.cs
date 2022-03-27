namespace Dashline.Core.Entity;

public class Flight
{
    public int ID { get; set; }
    public int PilotID { get; set; }
    public int LegID { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public DateTimeOffset CompletedDate { get; set; }
    public string Remarks { get; set; } = string.Empty;
    public string? Aircraft { get; set; }
    public TimeSpan Duration { get; set; }

    public Pilot? Pilot { get; set; }
    public Plan? Leg { get; set; }
}
