﻿using Examples.Enums;
using Examples.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Examples.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet]
    public ActionResult Index(int securityLevel = 1)
    {
      IndexModel model = new IndexModel();
      if (Enum.IsDefined(typeof(SecurityLevelEnum), securityLevel))
      {
        model.SecurityLevel = (SecurityLevelEnum)securityLevel;
        foreach (var command in Enum.GetValues(typeof(CommandEnum)))
        {
          var com = command.ToString();
          model.Commands.Add(new CommandModel()
          {
            CommandName = com,
            CommandText = com.ToLower()
          });
        }

        model.CommandArguments = string.Empty;
        model.Command = string.Empty;
      }
      return View(model);
    }

    [HttpPost, ValidateAntiForgeryToken]
    public JsonResult ProcessCommand(CommandRequestModel model)
    {
      var response = new CommandResponseModel();
      Process proc;
      if (!string.IsNullOrWhiteSpace(model.Command) && !string.IsNullOrWhiteSpace(model.Arguments))
      {
        try
        {
          proc = new Process
          {
            StartInfo = new ProcessStartInfo
            {
              FileName = model.Command,
              Arguments = model.Arguments,
              UseShellExecute = false,
              RedirectStandardOutput = true,
              RedirectStandardError = true,
              CreateNoWindow = true
            }
          };
          proc.Start();
          response.CommandOutput.Add("Running: " + model.Command);
          while (!proc.StandardOutput.EndOfStream)
          {
            var lineOutput = proc.StandardOutput.ReadLine();
            if (!string.IsNullOrWhiteSpace(lineOutput))
            {
              response.CommandOutput.Add(lineOutput);
            }
          }
          proc.Close();
          proc.Dispose();
          response.Success = true;
        }
        catch (Exception ex)
        {
          response.CommandOutput.Add(ex.Message);
          //if (proc.StandardError.ToString().Length > 0)
          //  response.CommandOutput.Add(proc.StandardError.ReadToEnd.ToString());
        }
      } else
      {
        response.CommandOutput.Add("ERROR");
      }
      return Json(response);
    }
  }
}