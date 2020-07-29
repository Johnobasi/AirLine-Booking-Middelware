using System;
using GreenAfrica_API.IdentityData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GreenAfrica_API.Data
{
    public partial class AIMSDATAContext : IdentityDbContext
    {
        

        public AIMSDATAContext(DbContextOptions<AIMSDATAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cpayroll> Cpayroll { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        //public virtual DbSet<CrewPayroll> CrewPayroll { get; set; }
        //public virtual DbSet<CustomerDetailsResponses> CustomerDetailsResponses { get; set; }
        public virtual DbSet<FlightInfo> FlightInfo { get; set; }
        //public virtual DbSet<FlightInfoFstp> FlightInfoFstp { get; set; }
        //public virtual DbSet<PushFacilityResponses> PushFacilityResponses { get; set; }
        //public virtual DbSet<PushObjectResults> PushObjectResults { get; set; }
        //public virtual DbSet<PushRequests> PushRequests { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Name=DataDBCon");
        //    }
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Cpayroll>(entity =>
        //    {
        //        entity.ToTable("cpayroll");

        //        entity.Property(e => e.CrewMemberId).HasMaxLength(50);

        //        entity.Property(e => e.CrewName).HasMaxLength(50);

        //        entity.Property(e => e.FlightDate).HasColumnType("datetime");

        //        entity.Property(e => e.SectorPay).HasColumnType("decimal(18, 2)");
        //    });

        //    modelBuilder.Entity<CrewPayroll>(entity =>
        //    {
        //        entity.HasKey(e => e.CrewMemberId);

        //        entity.ToTable("Crew_Payroll");

        //        entity.Property(e => e.CrewMemberId).HasColumnName("CrewMemberID");

        //        entity.Property(e => e.AcType)
        //            .HasColumnName("AC_Type")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.ActualBlockTime)
        //            .HasColumnName("Actual_Block_time")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ActualDateOfArrivalLocal)
        //            .HasColumnName("Actual_Date_of_Arrival_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ActualDateOfArrivalUtc)
        //            .HasColumnName("Actual_Date_of_Arrival_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ActualDateOfDepartureLocal)
        //            .HasColumnName("Actual_Date_of_Departure_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ActualDateOfDepartureUtc)
        //            .HasColumnName("Actual_Date_of_Departure_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ActualTimeOfArrivalLocal)
        //            .HasColumnName("Actual_Time_of_Arrival_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ActualTimeOfArrivalUtc)
        //            .HasColumnName("Actual_Time_of_Arrival_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ActualTimeOfDepartureLocal)
        //            .HasColumnName("Actual_Time_of_Departure_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ActualTimeOfDepartureUtc)
        //            .HasColumnName("Actual_Time_of_Departure_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ArrivalAirport)
        //            .HasColumnName("Arrival_Airport")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CreditHours)
        //            .HasColumnName("Credit_hours")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.CreditTime)
        //            .HasColumnName("Credit_time")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.Crew3LetterCode)
        //            .HasColumnName("Crew_3_Letter_Code")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CrewCategory)
        //            .HasColumnName("Crew_Category")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CrewFirstname)
        //            .HasColumnName("Crew_Firstname")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CrewMiddlename)
        //            .HasColumnName("Crew_Middlename")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CrewName)
        //            .HasColumnName("Crew_Name")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CrewSurname)
        //            .HasColumnName("Crew_Surname")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CrewmemberBase)
        //            .HasColumnName("Crewmember_base")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CrewmemberPosition)
        //            .HasColumnName("Crewmember_position")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.DeadHeadLeg)
        //            .HasColumnName("Dead_head_leg")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.DepartureAirport)
        //            .HasColumnName("Departure_Airport")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.DomesticBlocTime)
        //            .HasColumnName("Domestic_bloc_time")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.DomesticLayoverTime)
        //            .HasColumnName("Domestic_layover_time")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.DutyDebriefDateLocal)
        //            .HasColumnName("Duty_Debrief_Date_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.DutyDebriefDateUtc)
        //            .HasColumnName("Duty_Debrief_Date_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.DutyDebriefTimeLocal)
        //            .HasColumnName("Duty_Debrief_Time_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.DutyDebriefTimeUtc)
        //            .HasColumnName("Duty_Debrief_Time_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.DutyReportDateLocal)
        //            .HasColumnName("Duty_Report_Date_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.DutyReportDateUtc)
        //            .HasColumnName("Duty_Report_Date_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.DutyReportTimeLocal)
        //            .HasColumnName("Duty_Report_Time_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.DutyReportTimeUtc)
        //            .HasColumnName("Duty_Report_Time_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.DutyTime)
        //            .HasColumnName("Duty_time")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.FdpEndDateLocal)
        //            .HasColumnName("FDP_end_date_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.FdpEndDateUtc)
        //            .HasColumnName("FDP_end_date_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.FdpEndTimeLocal)
        //            .HasColumnName("FDP_end_time_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.FdpEndTimeUtc)
        //            .HasColumnName("FDP_end_time_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.FdpStartDateLocal)
        //            .HasColumnName("FDP_start_date_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.FdpStartDateUtc)
        //            .HasColumnName("FDP_start_date_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.FdpStartTimeLocal)
        //            .HasColumnName("FDP_start_time_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.FdpStartTimeUtc)
        //            .HasColumnName("FDP_start_time_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.FlightNumber)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.InternationalBlockTime)
        //            .HasColumnName("International_block_time")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.InternationalLayoverTime)
        //            .HasColumnName("International_layover_time")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.LayoverTime)
        //            .HasColumnName("Layover_time")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.LegSequenceNumber)
        //            .HasColumnName("Leg_Sequence_Number")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.LineNumber)
        //            .HasColumnName("Line_Number")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.NightHoursOfThePairing)
        //            .HasColumnName("Night_hours_of_the_pairing")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.NoOfLandings)
        //            .HasColumnName("No_of_landings")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.NoOfTakeOffs)
        //            .HasColumnName("No_of_take_offs")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.PaidDay)
        //            .HasColumnName("Paid_day")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.ScheduleDepartureDateDuty)
        //            .HasColumnName("Schedule_Departure_Date_duty")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ScheduledBlockTime)
        //            .HasColumnName("Scheduled_Block_time")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ScheduledDateOfArrivalLocal)
        //            .HasColumnName("Scheduled_Date_of_Arrival_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ScheduledDateOfArrivalUtc)
        //            .HasColumnName("Scheduled_Date_of_Arrival_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ScheduledDateOfDepartureLocal)
        //            .HasColumnName("Scheduled_Date_of_Departure_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ScheduledDateOfDepartureUtc)
        //            .HasColumnName("Scheduled_Date_of_Departure_UTC")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.ScheduledTimeOfArrivalLocal)
        //            .HasColumnName("Scheduled_Time_of_Arrival_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ScheduledTimeOfArrivalUtc)
        //            .HasColumnName("Scheduled_Time_of_Arrival_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ScheduledTimeOfDepartureLocal)
        //            .HasColumnName("Scheduled_Time_of_Departure_Local")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ScheduledTimeOfDepartureUtc)
        //            .HasColumnName("Scheduled_Time_of_Departure_UTC")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.SpecialActivity)
        //            .HasColumnName("Special_activity")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Tafb)
        //            .HasColumnName("TAFB")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.TafbOffset)
        //            .HasColumnName("TAFB_Offset")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.TailNumber)
        //            .HasColumnName("Tail_Number")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.TrainingDutyIndicator)
        //            .HasColumnName("Training_duty_indicator")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.TripNumber)
        //            .HasColumnName("Trip_number")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<CustomerDetailsResponses>(entity =>
        //    {
        //        entity.ToTable("customerDetailsResponses");

        //        entity.Property(e => e.AmountOfTheMonthlyPayment).HasColumnName("Amount_of_the_monthly_payment");

        //        entity.Property(e => e.ApprovedAmount).HasColumnName("Approved_amount");

        //        entity.Property(e => e.Bvn).HasColumnName("BVN");

        //        entity.Property(e => e.CbsCustomerId).HasColumnName("CBS_Customer_ID");

        //        entity.Property(e => e.CorrespondenceAddress).HasColumnName("Correspondence_address");

        //        entity.Property(e => e.CorrespondenceCounterpartyCountry).HasColumnName("Correspondence_Counterparty_Country");

        //        entity.Property(e => e.CountryOfResidence).HasColumnName("Country_of_Residence");

        //        entity.Property(e => e.CreditTo).HasColumnName("CreditTO");

        //        entity.Property(e => e.DateOfExpiry).HasColumnName("Date_Of_Expiry");

        //        entity.Property(e => e.DateOfIssue).HasColumnName("Date_Of_Issue");

        //        entity.Property(e => e.DateOfRelationship).HasColumnName("Date_of_Relationship");

        //        entity.Property(e => e.DebitTo).HasColumnName("DebitTO");

        //        entity.Property(e => e.Idnumber).HasColumnName("IDNumber");

        //        entity.Property(e => e.NbrOfPastDues).HasColumnName("Nbr_of_past_dues");

        //        entity.Property(e => e.NumberOfPastDues).HasColumnName("Number_of_Past_Dues");

        //        entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding_amount");

        //        entity.Property(e => e.PastDuesAmount)
        //            .HasColumnName("Past_dues_amount")
        //            .HasColumnType("decimal(18, 2)");

        //        entity.Property(e => e.PastDuesAmountCcy)
        //            .HasColumnName("Past_dues_amount_ccy")
        //            .HasColumnType("decimal(18, 2)");

        //        entity.Property(e => e.PermanentAddress).HasColumnName("Permanent_address");

        //        entity.Property(e => e.PermanentCounterpartyCountry).HasColumnName("Permanent_Counterparty_Country");

        //        entity.Property(e => e.PoliticallyExposedPerson).HasColumnName("Politically_Exposed_Person");

        //        entity.Property(e => e.SubSectorCode).HasColumnName("Sub_Sector_Code");
        //    });

        //    modelBuilder.Entity<FlightInfo>(entity =>
        //    {
        //        entity.HasKey(e => e.FlightId)
        //            .HasName("PK_FlightINFO_FSTP");

        //        entity.ToTable("FlightINFO");

        //        entity.Property(e => e.FlightId).HasColumnName("FlightID");

        //        entity.Property(e => e.Acregistration)
        //            .HasColumnName("ACRegistration")
        //            .HasMaxLength(80)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Actype)
        //            .HasColumnName("ACType")
        //            .HasMaxLength(30)
        //            .IsUnicode(false);

        //        entity.Property(e => e.ArrivalStation)
        //            .HasColumnName("Arrival_station")
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CallSsignAirlineCode)
        //            .HasColumnName("Call_ssign_airlineCode")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Cargo)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Carrier).HasMaxLength(50);

        //        entity.Property(e => e.CrewNumber)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.DepartureStation)
        //            .HasColumnName("Departure_Station")
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.DestinationAlternative)
        //            .HasColumnName("Destination_Alternative")
        //            .HasMaxLength(60)
        //            .IsUnicode(false);

        //        entity.Property(e => e.EtaEstimatedArrivalTime)
        //            .HasColumnName("ETA-EstimatedArrivalTime")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.EtdEstimatedDepartureTime)
        //            .HasColumnName("ETD-EstimatedDepartureTime")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.FlightNo)
        //            .HasColumnName("Flight_No")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.FlightNoPostfix)
        //            .HasColumnName("Flight_No_Postfix")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.InTime).HasColumnType("datetime");

        //        entity.Property(e => e.OffTime).HasColumnType("datetime");

        //        entity.Property(e => e.OnTime).HasColumnType("datetime");

        //        entity.Property(e => e.Operation)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.OutTime).HasColumnType("datetime");

        //        entity.Property(e => e.ScheduledDepartureDate)
        //            .HasColumnName("Scheduled_departureDate")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ServiceType)
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.StaScheduleArrivalTime)
        //            .HasColumnName("STA-ScheduleArrivalTime")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.StdShceduleDeaprtureTime)
        //            .HasColumnName("STD-ShceduleDeaprtureTime")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.TacticalflightNo)
        //            .HasColumnName("Tacticalflight_No")
        //            .HasMaxLength(40)
        //            .IsUnicode(false);

        //        entity.Property(e => e.TotalPax)
        //            .HasMaxLength(30)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<FlightInfoFstp>(entity =>
        //    {
        //        entity.HasKey(e => e.FlightId)
        //            .HasName("PK_FlightINFO_tbl");

        //        entity.ToTable("FlightINFO_FSTP");

        //        entity.Property(e => e.FlightId).HasColumnName("FlightID");

        //        entity.Property(e => e.Acregistration)
        //            .HasColumnName("ACRegistration")
        //            .HasMaxLength(80)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Actype)
        //            .HasColumnName("ACType")
        //            .HasMaxLength(30)
        //            .IsUnicode(false);

        //        entity.Property(e => e.ArrivalStation)
        //            .HasColumnName("Arrival_station")
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CallSsignAirlineCode)
        //            .HasColumnName("Call_ssign_airlineCode")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Cargo)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Carrier).HasMaxLength(50);

        //        entity.Property(e => e.CrewNumber)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.DepartureStation)
        //            .HasColumnName("Departure_Station")
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.DestimationAlternative)
        //            .HasMaxLength(60)
        //            .IsUnicode(false);

        //        entity.Property(e => e.EtaEstimatedArrivalTime)
        //            .HasColumnName("ETA-EstimatedArrivalTime")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.EtdEstimatedDepartureTime)
        //            .HasColumnName("ETD-EstimatedDepartureTime")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.FlightNo)
        //            .HasColumnName("Flight_No")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.FlightNoPostfix)
        //            .HasColumnName("Flight_No_Postfix")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.InTime).HasColumnType("datetime");

        //        entity.Property(e => e.OffTime).HasColumnType("datetime");

        //        entity.Property(e => e.Omtime).HasColumnType("datetime");

        //        entity.Property(e => e.Operation)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.OutTime).HasColumnType("datetime");

        //        entity.Property(e => e.ScheduledDepartureDate)
        //            .HasColumnName("Scheduled_departureDate")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.ServiceType)
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.StaScheduleArrivalTime)
        //            .HasColumnName("STA-ScheduleArrivalTime")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.StdShceduleDeaprtureTime)
        //            .HasColumnName("STD-ShceduleDeaprtureTime")
        //            .HasColumnType("datetime");

        //        entity.Property(e => e.TacticalflightNo)
        //            .HasColumnName("Tacticalflight_No")
        //            .HasMaxLength(40)
        //            .IsUnicode(false);

        //        entity.Property(e => e.TotalPax)
        //            .HasMaxLength(30)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<PushFacilityResponses>(entity =>
        //    {
        //        entity.HasIndex(e => e.DataId);

        //        entity.HasOne(d => d.Data)
        //            .WithMany(p => p.PushFacilityResponses)
        //            .HasForeignKey(d => d.DataId);
        //    });

        //    modelBuilder.Entity<PushObjectResults>(entity =>
        //    {
        //        entity.Property(e => e.AcpfacilityReference).HasColumnName("ACPFacilityReference");

        //        entity.Property(e => e.FcubsFacilityReference).HasColumnName("FCUBS_Facility_Reference");

        //        entity.Property(e => e.StatusOfFacilityPush).HasColumnName("Status_of_Facility_Push");
        //    });

        //    modelBuilder.Entity<PushRequests>(entity =>
        //    {
        //        entity.Property(e => e.AccrualBasis)
        //            .IsRequired()
        //            .HasColumnName("Accrual_basis");

        //        entity.Property(e => e.AcpfacilityReference)
        //            .IsRequired()
        //            .HasColumnName("ACPFacilityReference");

        //        entity.Property(e => e.Ao).HasColumnName("AO");

        //        entity.Property(e => e.Branch).IsRequired();

        //        entity.Property(e => e.FacilityRef)
        //            .IsRequired()
        //            .HasColumnName("Facility_Ref");

        //        entity.Property(e => e.FcubfacilityReference).HasColumnName("FCUBFacilityReference");

        //        entity.Property(e => e.FeesAmountccy).HasColumnType("decimal(18, 2)");

        //        entity.Property(e => e.FeesCalculatedAmount).HasColumnType("decimal(18, 2)");

        //        entity.Property(e => e.FeesType).HasColumnName("Fees_type");

        //        entity.Property(e => e.GracePeriodInMonth).HasColumnName("GracePeriod_in_Month");

        //        entity.Property(e => e.InstallmentAmount).HasColumnType("decimal(18, 2)");

        //        entity.Property(e => e.InstallmentAmountccy).HasColumnType("decimal(18, 2)");

        //        entity.Property(e => e.LoanFacilityAmount).HasColumnType("decimal(18, 2)");

        //        entity.Property(e => e.LoanFacilityAmountccy).HasColumnType("decimal(18, 2)");

        //        entity.Property(e => e.MprinterestRate).HasColumnName("MPRInterestRate");

        //        entity.Property(e => e.Spread).IsRequired();

        //        entity.Property(e => e.Vatamount)
        //            .HasColumnName("VATAmount")
        //            .HasColumnType("decimal(18, 2)");

        //        entity.Property(e => e.Vatrate).HasColumnName("VATRate");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
