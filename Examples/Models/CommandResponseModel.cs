using System.Collections.Generic;

namespace Examples.Models
{
  public class CommandResponseModel
  {
    public List<string> CommandOutput { get; set; } = new List<string>();
    public bool Success { get; set; }
  }
}