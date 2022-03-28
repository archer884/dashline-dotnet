namespace Dashline.Core.Entity;

public class Pilot
{
    public int ID { get; set; } = 0;
    public DateTimeOffset CreatedDate { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<Plan> Legs { get; set; } = null!;
    public ICollection<Flight> Flights { get; set; } = null!;

    public Pilot() { }

    public Pilot(string name)
    {
        Name = name;
    }
}
