using Examples.Interfaces;
using System.Collections.Generic;

namespace Examples.Models
{
  public class CommandResponseModel : ICommandResponse
  {
    public IList<string> CommandOutput { get; set; } = new List<string>();
    public bool Success { get; set; }
  }
}