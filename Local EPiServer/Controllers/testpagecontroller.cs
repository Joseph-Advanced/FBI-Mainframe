using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Local_EPiServer.Models.Pages;
using Local_EPiServer.Models.ViewModels;

namespace Local_EPiServer.Controllers
{
    public class testpagecontroller : PageController<testpage>
    {
        public ActionResult Index(testpage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            var viewmodel = new PageViewModel<testpage>(currentPage);
            return View(viewmodel);
        }
    }
}