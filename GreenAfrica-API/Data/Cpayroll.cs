using System;
using System.Collections.Generic;

namespace GreenAfrica_API.Data
{
    public partial class Cpayroll
    {
        public int Id { get; set; }
        public string CrewMemberId { get; set; }
        public string CrewName { get; set; }
        public DateTime? FlightDate { get; set; }
        public decimal? SectorPay { get; set; }
    }
}
