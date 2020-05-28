using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Web.Mvc;
using GCT.Models;
using System.Web.Security;

namespace GCT.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(Login model)
        {
            ViewBag.Message = "";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61633/api/login/login");
                var responseTask = client.PostAsJsonAsync("Login", model);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var userString = result.Content.ReadAsStringAsync().Result;

                    var userResult = new
                    {
                        ID = "",
                        Name = ""
                    };
                    var jsonResult = JsonConvert.DeserializeObject(userString);
                    var user = JsonConvert.DeserializeAnonymousType(jsonResult.ToString(), userResult);
                    if (user.ID != "0")
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, true);

                        return RedirectToAction("Dashboard", "Dashboard");

                    }
                    else
                    {
                        ViewBag.Message = "Incorrect User Name or Password";
                        return View("login");
                    }
                }
                else //web api sent error response 
                {
                    ViewBag.Message = "Unable to contact server! Please try after some time.";
                    return View("login");
                }
            }

        }
    }
}