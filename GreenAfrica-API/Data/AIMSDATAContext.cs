using GreenAfrica.DataAccess.Models;
using GreenAfrica_API.IdentityData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GreenAfrica_API.Data
{
    public partial class AIMSDATAContext : IdentityDbContext
    {
        public AIMSDATAContext(DbContextOptions<AIMSDATAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cpayroll> Cpayroll { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<CrewPayroll> CrewPayroll { get; set; }
        public virtual DbSet<CustomerDetailsResponses> CustomerDetailsResponses { get; set; }
        public virtual DbSet<FlightInfo> FlightInfo { get; set; }
    }
}