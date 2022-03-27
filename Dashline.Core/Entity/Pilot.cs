namespace Dashline.Core.Entity;

public class Pilot
{
    public int ID { get; set; } = 0;
    public DateTimeOffset CreatedDate { get; set; }
    
    // FIXME: Why does this need to be nullable?
    public string? Name { get; set; }

    // FIXME: And these! These are EF navigation properties, for heaven's sake!
    public ICollection<Plan>? Legs { get; set; }
    public ICollection<Flight>? Flights { get; set; }

    public Pilot() { }

    public Pilot(string name)
    {
        Name = name;
    }
}
