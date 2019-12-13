﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;

namespace WebSpeedEatApp.Controllers
{
    public class DishesController : Controller
    {

        private IDishesManager DishesManager { get; }

        public DishesController (IDishesManager dishesManager)
        {
            DishesManager = dishesManager;
        }
        // GET: Dishes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dishes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult GetAllDishes(int id)
        {
            var dishes = DishesManager.GetAllDishes(id);
            return View(dishes);
        }

        

        // GET: Dishes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dishes/Create
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

        // GET: Dishes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dishes/Edit/5
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

        // GET: Dishes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dishes/Delete/5
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