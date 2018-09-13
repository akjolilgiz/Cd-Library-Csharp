using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
    public class LibraryController : Controller
    {
        [HttpGet("/library")]
        public ActionResult Index()
        {
            List<Library> allLibraries = Library.GetAll();
            return View(allLibraries);
        }

        [HttpGet("/library/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/library")]
        public ActionResult Create()
        {
            Library newLibrary = new Library(Request.Form["artistLibrary"]);
            List<Library> allLibraries = Library.GetAll();
            return View("Index", allLibraries);
        }

        [HttpGet("/library/{id}")]
        public ActionResult Details(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Library selectedLibrary = Library.Find(id);
            List<Cds> libraryCds = selectedLibrary.GetCds();
            model.Add("library", selectedLibrary);
            model.Add("cds", libraryCds);
            return View(model);
        }

        [HttpPost("/cds")]
        public ActionResult CreateCds(int libraryId, string title)
        {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Library foundLibrary = Library.Find(libraryId);
        Cds newCd = new Cds(title);
        foundLibrary.AddCd(newCd);
        List<Cds> libraryCds = foundLibrary.GetCds();
        model.Add("cds", libraryCds);
        model.Add("library", foundLibrary);
        return View("Details", model);
        }
    }
}
