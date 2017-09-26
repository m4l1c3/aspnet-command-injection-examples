using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Examples.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      IndexModel model = new IndexModel();
      model.Commands.Add(new CommandModel()
      {
        CommandName = "Ping",
        CommandText = "ping"
      });
      model.Commands.Add(new CommandModel()
      {
        CommandName = "Netstat",
        CommandText = "netstat"
      });
      model.Commands.Add(new CommandModel()
      {
        CommandName = "Dig",
        CommandText = "dig"
      });
      model.CommandArguments = string.Empty;
      model.Command = string.Empty;
      return View(model);
    }

    public ActionResult ProcessCommand(CommandModel model)
    {
      return View();
    }
  }
}