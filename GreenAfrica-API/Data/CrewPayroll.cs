using System;
using System.Collections.Generic;

namespace GreenAfrica_API.Data
{
    public partial class CrewPayroll
    {
        public int CrewMemberId { get; set; }
        public string CrewmemberPosition { get; set; }
        public string CrewmemberBase { get; set; }
        public DateTime? ScheduleDepartureDateDuty { get; set; }
        public string TripNumber { get; set; }
        public DateTime? DutyReportDateUtc { get; set; }
        public DateTime? DutyReportTimeUtc { get; set; }
        public DateTime? DutyReportDateLocal { get; set; }
        public DateTime? DutyReportTimeLocal { get; set; }
        public DateTime? DutyDebriefDateUtc { get; set; }
        public DateTime? DutyDebriefTimeUtc { get; set; }
        public DateTime? DutyDebriefDateLocal { get; set; }
        public DateTime? DutyDebriefTimeLocal { get; set; }
        public string DeadHeadLeg { get; set; }
        public string TailNumber { get; set; }
        public string AcType { get; set; }
        public string FlightNumber { get; set; }
        public string LegSequenceNumber { get; set; }
        public string DepartureAirport { get; set; }
        public string ScheduledDateOfDepartureUtc { get; set; }
        public DateTime? ScheduledTimeOfDepartureUtc { get; set; }
        public DateTime? ScheduledDateOfDepartureLocal { get; set; }
        public DateTime? ScheduledTimeOfDepartureLocal { get; set; }
        public DateTime? ActualDateOfDepartureUtc { get; set; }
        public DateTime? ActualTimeOfDepartureUtc { get; set; }
        public DateTime? ActualDateOfDepartureLocal { get; set; }
        public DateTime? ActualTimeOfDepartureLocal { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime? ScheduledDateOfArrivalUtc { get; set; }
        public DateTime? ScheduledTimeOfArrivalUtc { get; set; }
        public DateTime? ScheduledDateOfArrivalLocal { get; set; }
        public DateTime? ScheduledTimeOfArrivalLocal { get; set; }
        public DateTime? ActualDateOfArrivalUtc { get; set; }
        public DateTime? ActualTimeOfArrivalUtc { get; set; }
        public DateTime? ActualDateOfArrivalLocal { get; set; }
        public DateTime? ActualTimeOfArrivalLocal { get; set; }
        public DateTime? ScheduledBlockTime { get; set; }
        public DateTime? ActualBlockTime { get; set; }
        public DateTime? FdpStartDateUtc { get; set; }
        public DateTime? FdpStartTimeUtc { get; set; }
        public DateTime? FdpStartDateLocal { get; set; }
        public DateTime? FdpStartTimeLocal { get; set; }
        public DateTime? FdpEndDateUtc { get; set; }
        public DateTime? FdpEndTimeUtc { get; set; }
        public DateTime? FdpEndDateLocal { get; set; }
        public DateTime? FdpEndTimeLocal { get; set; }
        public DateTime? LayoverTime { get; set; }
        public string TrainingDutyIndicator { get; set; }
        public string Tafb { get; set; }
        public string SpecialActivity { get; set; }
        public string PaidDay { get; set; }
        public DateTime? CreditHours { get; set; }
        public string LineNumber { get; set; }
        public string TafbOffset { get; set; }
        public string CrewName { get; set; }
        public string CrewSurname { get; set; }
        public string CrewFirstname { get; set; }
        public string CrewMiddlename { get; set; }
        public string Crew3LetterCode { get; set; }
        public string CrewCategory { get; set; }
        public DateTime? DutyTime { get; set; }
        public DateTime? CreditTime { get; set; }
        public DateTime? DomesticBlocTime { get; set; }
        public DateTime? InternationalBlockTime { get; set; }
        public DateTime? DomesticLayoverTime { get; set; }
        public DateTime? InternationalLayoverTime { get; set; }
        public string NightHoursOfThePairing { get; set; }
        public string NoOfLandings { get; set; }
        public string NoOfTakeOffs { get; set; }
    }
}
