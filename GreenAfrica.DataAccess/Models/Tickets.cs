using System;
using System.Collections.Generic;

namespace GreenAfrica.DataAccess.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public Guid Number { get; set; }
        public DateTime Time { get; set; }

        IEnumerable<Passenger> passengers { get; set; }

    }
}
