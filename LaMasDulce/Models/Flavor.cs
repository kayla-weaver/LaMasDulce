using System.Collections.Generic;
namespace LaMasDulce.Models
{
  public class Flavor
  {
  
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
   

    public string Name { get; }
    
    public virtual ICollection<TreatFlavor> JoinEntities { get; set; }
  }
}