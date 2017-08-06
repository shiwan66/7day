using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employees.Entities;
using Business.Service;
using System.Web.Security;

namespace WebApplication1.Controllers
{
    [AllowAnonymous]
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult DoLogin(UserDetails u)
        {
            if(ModelState.IsValid)
            {
                EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
                UserStatus status = bal.GetUserValidity(u);
                bool IsAdmin = false;
                if(status == UserStatus.AuthenticatedAdmin)
                {
                    IsAdmin = true;
                } 
                else if(status == UserStatus.AuthenticatedUser)
                {
                    IsAdmin = false;
                }
                else
                {
                    ModelState.AddModelError("CredentialError", "Invalid Username or Password");
                    return View("Login");
                }
                FormsAuthentication.SetAuthCookie(u.UserName, false);
                Session["IsAdmin"] = IsAdmin;
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View("Login");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}