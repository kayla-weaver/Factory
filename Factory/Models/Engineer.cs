using System.Collections.Generic;
using Microsoft.Identity.Client;
namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int EngineerId { get; set; }
    public string Name { get; set;}
    public List<Machine> Machines { get; set; }
    public virtual ICollection <EngineerMachine> JoinEntities { get; set; }
  }
}