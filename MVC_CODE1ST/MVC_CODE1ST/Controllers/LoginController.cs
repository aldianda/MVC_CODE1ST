using MVC_CODE1ST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BCrypt.Net;

namespace MVC_CODE1ST.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        ApplicationDbContext myContext = new ApplicationDbContext();
        public ActionResult Index()
        {
            var list = myContext.Users.ToList();
            return View(list);
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                // TODO: Add insert logic here
                myContext.Users.Add(user);
                myContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, User user)
        {
            try
            {
                // TODO: Add delete logic here
                var del = myContext.Users.Find("id");
                myContext.Users.Remove(del);
                myContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //get
        public ActionResult Login()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var check = myContext.Users.SingleOrDefault(e => e.email.Equals(user.email));

            if (check != null)
            {
                if(Hashing.ValidatePassword(user.password, check.password))
                {
                    return RedirectToAction("Index");
                }
                else
                {

                }
            }
            else
            {
                return RedirectToAction("Login");

            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            user.password = Hashing.HashPassword(user.password);
            myContext.Users.Add(user);
            var createEmail = myContext.Users.Add(user);
            myContext.SaveChanges();
            return View();
            return RedirectToAction("Index");
        }
    }
}
