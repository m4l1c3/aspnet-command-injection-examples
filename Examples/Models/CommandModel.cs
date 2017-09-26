using Examples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examples.Models
{
  public class CommandModel : ICommand
  {
    public string CommandName { get; set; }
    public string CommandText { get; set; }
    public string Arguments { get; set; }
  }
}