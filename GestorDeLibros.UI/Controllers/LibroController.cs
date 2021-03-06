using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestorDeLibros.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestorDeLibros.UI.Controllers
{
    public class LibroController : Controller
    {

        private GestorDeLibros.UI.Models.IRepositoriodeLibros Repositorio;

        public LibroController(GestorDeLibros.UI.Models.IRepositoriodeLibros repositoriodeLibros)
        {
            Repositorio = repositoriodeLibros;
        }

        // GET: Libro
        public ActionResult Index()
        {
            List<GestorDeLibros.UI.Models.Libro> LaList;
            LaList =  Repositorio.ObtenerTodo();
            return View(LaList);
        }

        // GET: Libro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Libro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Libro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Libro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Libro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Libro/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}