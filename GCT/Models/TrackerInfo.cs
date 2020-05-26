using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GCT.Models
{
    public class TrackerInfo
    {
        public int ProjectCode { get; set; }
        public int ProjectId { get; set; }
        public int RegionId { get; set; }
        public int CountryId { get; set; }
        public string ResponsibilityCenterNumber { get; set; }
        public string ResponsibilityCenterName{ get; set; }
        public int ExpenseCategory { get; set; }
        public int VendorId { get; set; }
        public int RequsitionNumber { get; set; }
        public int CurrencyCodeId { get; set; }
        public decimal LocalCurrencyFxRate { get; set; }
        public decimal LocalCurrencyRPIRate { get; set; }
        public int BudgetLocalCurrency { get; set; }
        public int BudgetUSD { get; set; }
        public int ActualLocalCurrency { get; set; }
        public int ActualUSD { get; set; }
        public DateTimeOffset CashStartDate { get; set; }
        public DateTimeOffset CashEndDate { get; set; }
        public DateTimeOffset PLStartDate { get; set; }
        public DateTimeOffset PLEndDate { get; set; }
        public string RequisitonDescription { get; set; }
        public int PrimaryVariance { get; set; }
        public int SecondaryVariance { get; set; }
        public int ReceiptNumber { get; set; }
        public string Comments { get; set; }
        public int Renewal { get; set; }
        public int Jan { get; set; }
        public int Feb { get; set; }
        public int Mar { get; set; }
        public int Apr { get; set; }
        public int May { get; set; }
        public int Jun { get; set; }
        public int Jul { get; set; }
        public int Aug { get; set; }
        public int Sep { get; set; }
        public int Oct { get; set; }
        public int Nov { get; set; }
        public int Dec { get; set; }
        public int Total { get; set; }
        public int VarianceToBudget { get; set; }
        public int BudgetLocalCurrencyNextYear { get; set; }
        public int BudgetNextYear { get; set; }
        public int InternalBudgetContact { get; set; }
        public int ITDirectorUserId { get; set; }
        public string AdditionalComment { get; set; }


    }
}