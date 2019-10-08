using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prueba.Controllers
{
    public class HelloWordController : Controller
    {
        // GET: HelloWord
        public string Index1() {
            return "this  is  <b> default</b>  action..";
        }

      

        public string Welcome2(string name, int id = 1)
        {
            return HttpUtility.HtmlDecode("HELLO" + name + "id" + id);

        }
        public ActionResult Index() {
            return View  ();
        
        }
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "hello" + name;
            ViewBag.numTimes = numTimes;


   return View();
        }


    }
}