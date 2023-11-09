using System.Collections.Generic;
namespace LaMasDulce.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }

    public virtual ICollection <TreatFlavor> JoinEntities { get; set; }
  }
}