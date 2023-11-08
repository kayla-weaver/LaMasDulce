using System.Collections.Generic;
namespace LaMasDulce.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public List<Treat> Treats { get; set; }

    public string Name { get; }
    
    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}