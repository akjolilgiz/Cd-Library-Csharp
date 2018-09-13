using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CdOrganizer.Controllers;
using CdOrganizer.Models;

namespace CdOrganizer.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
          return View();
      }
    }
}
