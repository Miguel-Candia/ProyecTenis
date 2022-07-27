using ProyecTenis.DAO;
using ProyecTenis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyecTenis.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin
        public ActionResult Index() {
            //     return Content("Hola");

            UserDao userDao = new UserDao();
            return View(userDao.GetAll());
        }


        // GET: Admin/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create() {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection) {
            try {
                UserDao userDao = new UserDao();
                User user = new User();
                user.Name = collection["Name"];
                user.LastName = collection["LastName"];
                user.Phone = collection["Phone"];
                user.Email = collection["Email"];
                Console.WriteLine(user.Name);
                var result = userDao.Ingresar(user);
                if (result) {
                    return RedirectToAction("Index");
                } else {
                    return View();
                }
            }
            catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                // return redirectToAction("Create");
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
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

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
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
