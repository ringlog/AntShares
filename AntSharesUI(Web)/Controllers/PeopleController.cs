using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using AntSharesUI_Web_.Models;

namespace AntSharesUI_Web_.Controllers
{
    public class PeopleController : Controller
    {

        // GET: People/PeopleList
        public IActionResult PeopleList()
        {
            return View();
        }

        // GET: People/People
        public IActionResult People()
        {
            return View();
        }

    }
}