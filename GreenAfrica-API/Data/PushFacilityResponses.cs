using System;
using System.Collections.Generic;

namespace GreenAfrica_API.Data
{
    public partial class PushFacilityResponses
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }
        public int? DataId { get; set; }

        public virtual PushObjectResults Data { get; set; }
    }
}
