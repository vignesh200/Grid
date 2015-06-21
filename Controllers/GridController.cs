using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grid.Controllers
{
    public class GridController : Controller
    {
        // GET: Grid
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowGrid()
        {
            return View();
        }
        public ActionResult GridData()
        {
            string[] s = new string[] { "Id", "Name","Rollno","Std"};
            string[][] k = new string[][] { new string[] { "C1", "Vigneh", "1","V" }, new string[] { "C2", "Kathesh", "2", "VI"} };
            return Json(new { information=s,data=k},JsonRequestBehavior.AllowGet);
        }
        public ActionResult ShowGrid2()
        {
            return View();
        }


    }
}