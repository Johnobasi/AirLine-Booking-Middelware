using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GreenAfrica_API.Data
{
    public partial class FlightInfo
    {
        [Key]
        public int FlightId { get; set; }
        public string Operation { get; set; }
        public DateTime? ScheduledDepartureDate { get; set; }
        public string Carrier { get; set; }
        public string FlightNo { get; set; }
        public string FlightNoPostfix { get; set; }
        public string CallSsignAirlineCode { get; set; }
        public string TacticalflightNo { get; set; }
        public string DepartureStation { get; set; }
        public string ArrivalStation { get; set; }
        public DateTime? StdShceduleDeaprtureTime { get; set; }
        public DateTime? StaScheduleArrivalTime { get; set; }
        public DateTime? EtdEstimatedDepartureTime { get; set; }
        public DateTime? EtaEstimatedArrivalTime { get; set; }
        public DateTime? OutTime { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? OffTime { get; set; }
        public DateTime? OnTime { get; set; }
        public string Actype { get; set; }
        public string Acregistration { get; set; }
        public string ServiceType { get; set; }
        public string TotalPax { get; set; }
        public string Cargo { get; set; }
        public string DestinationAlternative { get; set; }
        public string CrewNumber { get; set; }
    }
}
