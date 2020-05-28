using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GCT.Models
{
    public class TrackerInfo
    {
        public int ProjectCode { get; set; }
        public int ProjectId { get; set; }
        public int RegionId { get; set; }
        public int CountryId { get; set; }
        public List<SelectListItem> CountryNameList { get; set; }
        public string ResponsibilityCenterNumber { get; set; }
        public string ResponsibilityCenterName{ get; set; }
        public int ExpenseCategory { get; set; }
        public int VendorId { get; set; }
        public List<SelectListItem> VendorsList { get; set; }
        public int RequsitionNumber { get; set; }
        public int CurrencyCodeId { get; set; }
        public List<SelectListItem> CurrencyCodeList { get; set; }
        public decimal LocalCurrencyFxRate { get; set; }
        public List<SelectListItem> LocalCurrencyFRList { get; set; }
        public decimal LocalCurrencyRPIRate { get; set; }
        public List<SelectListItem> LocalCurrencyRRList { get; set; }
        public decimal BudgetLocalCurrency { get; set; }
        public decimal BudgetUSD { get; set; }
        public decimal ActualLocalCurrency { get; set; }
        public decimal ActualUSD { get; set; }
        public DateTimeOffset CashStartDate { get; set; }
        public DateTimeOffset CashEndDate { get; set; }
        public DateTimeOffset PLStartDate { get; set; }
        public DateTimeOffset PLEndDate { get; set; }
        public string RequisitonDescription { get; set; }
        public string PrimaryVariance { get; set; }
        public List<SelectListItem> PrimaryVarianceList { get; set; }
        public string SecondaryVariance { get; set; }
        public List<SelectListItem> SecondaryVarianceList { get; set; }
        public string ReceiptNumber { get; set; }
        public string Comments { get; set; }
        public int Renewal { get; set; }
        public List<SelectListItem> RenewalList { get; set; }
        public decimal Jan { get; set; }
        public decimal Feb { get; set; }
        public decimal Mar { get; set; }
        public decimal Apr { get; set; }
        public decimal May { get; set; }
        public decimal Jun { get; set; }
        public decimal Jul { get; set; }
        public decimal Aug { get; set; }
        public decimal Sep { get; set; }
        public decimal Oct { get; set; }
        public decimal Nov { get; set; }
        public decimal Dec { get; set; }
        public decimal Total { get; set; }
        public decimal VarianceToBudget { get; set; }
        public decimal BudgetLocalCurrencyNextYear { get; set; }
        public decimal BudgetNextYear { get; set; }
        public string InternalBudgetContact { get; set; }
        public string ITDirectorUserId { get; set; }
        public string AdditionalComment { get; set; }
        public decimal USD { get; set; }
        public decimal VAT { get; set; }
        public decimal Inflation1 { get; set; }
        public decimal Inflation2 { get; set; }


    }
}