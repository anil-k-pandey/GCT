using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GCT.Models;

namespace GCT.Controllers
{
    public class BudgetDetailsController : Controller
    {
        private TrackerInfo Info = new TrackerInfo();

        // GET: BudgetDetails
        public ActionResult Index()
        {
            Info.CountryNameList = new List<SelectListItem> {
                new SelectListItem { Text = "--Select--", Value = "" },
                new SelectListItem { Text = "Argentina", Value = "01" },
                new SelectListItem { Text = "Rest from DB", Value = "00" }
            };

            Info.VendorsList = new List<SelectListItem> {
                new SelectListItem { Text = "--Select--", Value = "" },
                new SelectListItem { Text  = "Acturis Ltd", Value = "01"},
                new SelectListItem { Text = "Rest from DB", Value = "00" }
            };

            Info.CurrencyCodeList = new List<SelectListItem> {
                new SelectListItem { Text = "--Select--", Value = "" },
                new SelectListItem { Text  = "ARS", Value = "01"},
                new SelectListItem { Text = "Rest from DB", Value = "00" }
            };

            Info.LocalCurrencyFRList = new List<SelectListItem> {
                new SelectListItem { Text = "--Select--", Value = "" },
                new SelectListItem { Text  = "0.014286", Value = "01"},
                new SelectListItem { Text = "Rest from DB", Value = "00" }
            };

            Info.LocalCurrencyRRList = new List<SelectListItem> {
                new SelectListItem { Text = "--Select--", Value = "" },
                new SelectListItem { Text  = "1", Value = "01"},
                new SelectListItem { Text = "Rest from DB", Value = "00" }
            };

            Info.PrimaryVarianceList = new List<SelectListItem> {
                new SelectListItem { Text = "--Select--", Value = "" },
                new SelectListItem { Text  = "RPI", Value = "01"},
                new SelectListItem { Text = "Rest from DB", Value = "00" }
            };

            Info.SecondaryVarianceList = new List<SelectListItem> {
                new SelectListItem { Text = "--Select--", Value = "" },
                new SelectListItem { Text  = "JLT Increamental", Value = "01"},
                new SelectListItem { Text = "Rest from DB", Value = "00" }
            };

            Info.RenewalList = new List<SelectListItem> {
                new SelectListItem { Text = "--Select--", Value = "" },
                new SelectListItem { Text  = "Yes", Value = "00"},
                new SelectListItem { Text = "No", Value = "01" },
                new SelectListItem { Text = "Rest from DB if required", Value = "02" }
            };

            return View(Info);
        }

        public ActionResult UpdateBudgetDetails()
        {
            return View(Info);
        }
    }
}