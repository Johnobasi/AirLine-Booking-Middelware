using System;
using System.Collections.Generic;

namespace GreenAfrica_API.Data
{
    public partial class PushObjectResults
    {
        public PushObjectResults()
        {
            PushFacilityResponses = new HashSet<PushFacilityResponses>();
        }

        public int Id { get; set; }
        public string AcpfacilityReference { get; set; }
        public string FcubsFacilityReference { get; set; }
        public string StatusOfFacilityPush { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }

        public virtual ICollection<PushFacilityResponses> PushFacilityResponses { get; set; }
    }
}
