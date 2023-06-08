using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using learning.net.Models;

namespace learning.net.Controllers
{   
    [RoutePrefix("mvs")]
    [Route("{action}")]
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("testingchanges")]
        public ActionResult Random()
        {
            return View();
        }
    }
}