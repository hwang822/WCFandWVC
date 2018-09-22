using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MixwellMvc.Models;

namespace MixwellMvc.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult Display()
        {   //

            Dept dept = new Dept() { Name = "Computer Science"};
            return View(dept);

            //http://localhost:28327/Dept/Display
            //Comuter Scientce


            //return Content("Hello World!");
            //return DisplayHttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
        }


        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //http://localhost:28327/Dept/Edit/10
        //id=10

        //defautl action
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            //http://localhost:28327/Dept
            //pageIndex = 1 & sortBy = Name

            //http://localhost:28327/Dept?pageIndex=2&sortBy=Henry
            //pageIndex=2&sortBy=Henry

        }


    }
}