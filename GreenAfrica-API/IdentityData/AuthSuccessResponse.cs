using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace GreenAfrica_API.IdentityData
{
    public class AuthSuccessResponse
    {
        public string Token{ get; set; }
        public string RefreshToken { get; set; }

    }
}
