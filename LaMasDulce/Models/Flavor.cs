using System.Collections.Generic;
namespace LaMasDulce.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<TreatFlavor>();
    }
    
  }
}