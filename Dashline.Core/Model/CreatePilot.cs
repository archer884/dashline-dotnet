using Dashline.Core.Entity;

namespace Dashline.Core.Model;

public class CreatePilot
{
    public string? Name { get; set; }

    public Pilot AsPilot()
    {
        if (Name == null)
        {
            throw new ArgumentNullException(nameof(Name));
        }

        return new Pilot
        {
            Name = Name,
            CreatedDate = Time.Now,
        };
    }
}
