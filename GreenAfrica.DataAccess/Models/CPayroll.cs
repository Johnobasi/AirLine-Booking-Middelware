using System;
using System.Collections.Generic;
using System.Text;

namespace GreenAfrica.DataAccess.Models
{
    public partial class CPayroll
    {
        public int Id { get; set; }
        public string CrewMemberId { get; set; }
        public string CrewName { get; set; }
        public DateTime? FlightDate { get; set; }
        public decimal? SectorPay { get; set; }
    }
}
