using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Interfaces
{
  public interface ICommand
  {
    string CommandName { get; set; }
    string CommandText { get; set; }
    string Arguments { get; set; }
  }
}
