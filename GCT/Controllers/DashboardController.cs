using GCT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GCT.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public async Task<ActionResult> Dashboard()
        {
            var model = new TrackerInfo();

             string apiUrl = "http://localhost:61633/api/Trackers/GetTrackers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<TrackerModel>>();
                    //var details = Newtonsoft.Json.JsonConvert.DeserializeObject<TrackerModel>(data);
                    model.TrackerModels= data;
                }
            }           

                return View("Dashboard",model);
        }
    }
}