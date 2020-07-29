using System;
using System.Collections.Generic;

namespace GreenAfrica_API.Data
{
    public partial class PushRequests
    {
        public int Id { get; set; }
        public string AcpfacilityReference { get; set; }
        public string Branch { get; set; }
        public string Ao { get; set; }
        public string Customer { get; set; }
        public string DisbursementMode { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public decimal LoanFacilityAmount { get; set; }
        public decimal LoanFacilityAmountccy { get; set; }
        public string TenorMonth { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime FirstPaymentDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public decimal InstallmentAmount { get; set; }
        public decimal InstallmentAmountccy { get; set; }
        public string MprinterestRate { get; set; }
        public string PrincipalFrequency { get; set; }
        public string AccrualBasis { get; set; }
        public string InterestFrequency { get; set; }
        public string GraceCalculationMethod { get; set; }
        public string GracePeriodInMonth { get; set; }
        public string AmortizationType { get; set; }
        public string FeesType { get; set; }
        public string FeesRate { get; set; }
        public string FeesFrequency { get; set; }
        public decimal Vatamount { get; set; }
        public string Vatrate { get; set; }
        public decimal FeesCalculatedAmount { get; set; }
        public decimal FeesAmountccy { get; set; }
        public string FcubfacilityReference { get; set; }
        public string Spread { get; set; }
        public string FacilityRef { get; set; }
    }
}
