using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ContentResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return new Return new RedirectResult("/");
            }
            return new ContentResult()
            {
             
                Content = "Hello from the comic books controller!"
            };      
        }
    }
}