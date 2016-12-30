using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p> Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revange! Even is Soider-Man surrvives....<strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Viktor Olazaba",
                "Colors:Edgar Delgado",
                "Letters: Chris Eliopulos"
            };

            return View(); 
        }
    }
}