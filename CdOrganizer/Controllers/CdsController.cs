using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
    public class CdsController : Controller
    {

        // [HttpGet("/cds")]
        // public ActionResult Index()
        // {
        //     List<Cds> allCds = Cds.GetAll();
        //     return View(allCds);
        // }

        [HttpGet("/library/{libraryId}/cds/new")]
         public ActionResult CreateForm(int libraryId)
         {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Library library = Library.Find(libraryId);
            return View(library);
         }
         [HttpGet("/library/{libraryId}/cds/{cdId}")]
         public ActionResult Details(int libraryId, int cdId)
         {
            Cds cd = Cds.Find(cdId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            Library library = Library.Find(libraryId);
            model.Add("cd", cd);
            model.Add("library", library);
            return View(cd);
         }
        [HttpPost("/cds/delete")]
        public ActionResult DeleteAll()
        {
            Cds.ClearAll();
            return View();
        }
        [HttpGet("/cds/{id}")]
        public ActionResult Details(int id)
        {
            Cds cd = Cds.Find(id);
            return View(cd);
        }
    }
}
