using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prueba.Controllers
{
    public class listaMovie : Controller
    {
        // GET: listaMovie
        public ActionResult Index()
        {
            return View();
        }

        // GET: listaMovie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: listaMovie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: listaMovie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: listaMovie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: listaMovie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: listaMovie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: listaMovie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
