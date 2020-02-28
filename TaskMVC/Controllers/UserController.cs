using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            Models.UserRepository userRepository = new Models.UserRepository();
            ViewBag.Name = userRepository.GetAllUsers();
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            Models.UserRepository userRepository = new Models.UserRepository();

            ViewBag.Name = userRepository.GetUserById(id);

            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(Models.User list)
        {
            Models.UserRepository userRepository = new Models.UserRepository();
            userRepository.Create(list);
            return View();
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Models.User collection)
        {
            Models.UserRepository userRepository = new Models.UserRepository();
            userRepository.Update(collection);
            return View();
        
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            Models.UserRepository userRepository = new Models.UserRepository();
            userRepository.Delete(id);
            ViewBag.Message = userRepository.GetAllUsers();
            return View();
        }

        // POST: User/Delete/5
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
