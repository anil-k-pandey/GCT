using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using GCT.Models;
using Newtonsoft.Json;


namespace GCT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "";

            return View();
        }

        [HttpPost]
        public ActionResult Login(Login model)
        {
            ViewBag.Message = "";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:61633/api/login/login");                
                var responseTask =  client.PostAsJsonAsync("Login", model);
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
                    var user = JsonConvert.DeserializeAnonymousType(jsonResult.ToString(),userResult);
                    if (user.ID != "0")
                    {
                        return View("Dashboard");
                       
                    }
                    else //web api sent error response 
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
                return View();
            }
           
        }

        public ActionResult Cancel()
        {
            return View("Index");
        }
    }
}