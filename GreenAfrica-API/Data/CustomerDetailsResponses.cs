using System;
using System.Collections.Generic;

namespace GreenAfrica_API.Data
{
    public partial class CustomerDetailsResponses
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public int CbsCustomerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string CustomerType { get; set; }
        public string Segment { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string BirthCountry { get; set; }
        public string Nationality { get; set; }
        public string BirthPlace { get; set; }
        public string CountryOfResidence { get; set; }
        public string Dependents { get; set; }
        public string Title { get; set; }
        public string Bvn { get; set; }
        public string IdentificationType { get; set; }
        public string Idnumber { get; set; }
        public string IssuingAuthority { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public string SectorCode { get; set; }
        public string SubSectorCode { get; set; }
        public string Occupation { get; set; }
        public string CustomerGroup { get; set; }
        public string NumberOfPastDues { get; set; }
        public decimal PastDuesAmount { get; set; }
        public decimal PastDuesAmountCcy { get; set; }
        public string PoliticallyExposedPerson { get; set; }
        public string CustomerClassification { get; set; }
        public string Branch { get; set; }
        public string RelationshipManager { get; set; }
        public DateTime DateOfRelationship { get; set; }
        public string AccountClasses { get; set; }
        public DateTime OpeningDate { get; set; }
        public string AccountNumber { get; set; }
        public string AccountBalance { get; set; }
        public DateTime BalanceDate { get; set; }
        public string DebitTo { get; set; }
        public string Limit { get; set; }
        public string CreditTo { get; set; }
        public string CorrespondenceCounterpartyCountry { get; set; }
        public string CorrespondenceState { get; set; }
        public string CorrespondenceAddress { get; set; }
        public string PermanentCounterpartyCountry { get; set; }
        public string PermanentState { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string ContractReferenceNumber { get; set; }
        public string ProductType { get; set; }
        public string Product { get; set; }
        public string AmountOfTheMonthlyPayment { get; set; }
        public string OutstandingAmount { get; set; }
        public string ApprovedAmount { get; set; }
        public string Currency { get; set; }
        public string Spread { get; set; }
        public DateTime BookDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public string NbrOfPastDues { get; set; }
    }
}
