using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Interfaces
{
  public interface ICommandResponse
  {
    IList<string> CommandOutput { get; set; }
    bool Success { get; set; }
  }
}
