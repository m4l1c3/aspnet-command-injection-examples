using Examples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examples.Models
{
  public class IndexModel
  {
    public List<ICommand> Commands { get; set; } = new List<ICommand>();
    public string Command { get; set; }
    public string CommandArguments { get; set; }
  }
}