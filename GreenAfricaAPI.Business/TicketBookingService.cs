using GreenAfrica.DataAccess.Models;
using GreenAfricaAPI.Business.Abstract;
using GreenAfricaAPI.Business.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreenAfricaAPI.Business
{
    public class TicketBookingService : ITicketBookingService
    {
        private readonly ITicketBookingRepository _ticketBookingRepository;

        public TicketBookingService(ITicketBookingRepository ticketBookingRepository)
        {
            _ticketBookingRepository = ticketBookingRepository;
        }

        public async Task AddTicketBookingAsync(TicketBooking ticketBooking)
        {
            await _ticketBookingRepository.AddAsync(ticketBooking);
            await _ticketBookingRepository.SaveChangesAsync();
        }

        public Task<TicketBooking> GetTicketBookingAsyncById(int ticketBookingId)
        {
            return GetTicketBookingAsyncById(ticketBookingId);
        }

        public Task<IEnumerable<TicketBooking>> GetTicketBookingsAsync(Func<TicketBooking, bool> predicate)
        {
            return GetTicketBookingsAsync(predicate);
        }

        public async Task UpdateTicketBookingAsync(int id, TicketBooking request)
        {
            var existingTicketBooking = await _ticketBookingRepository.GetTicketBookingAsyncById(id);

            existingTicketBooking.ArrivalDate = request.ArrivalDate ?? existingTicketBooking.ArrivalDate;
            existingTicketBooking.Departure = request.Departure ?? existingTicketBooking.Departure;
            existingTicketBooking.DepartureDate = request.DepartureDate ?? existingTicketBooking.DepartureDate;
            existingTicketBooking.Destination = request.Destination ?? existingTicketBooking.Destination;
            existingTicketBooking.FirstName = request.FirstName ?? existingTicketBooking.FirstName;
            existingTicketBooking.EmailAddress = request.EmailAddress ?? existingTicketBooking.EmailAddress;
            existingTicketBooking.Dob = request.Dob ?? existingTicketBooking.Dob;
            existingTicketBooking.EmergencyPhoneNumber = request.EmergencyPhoneNumber ?? existingTicketBooking.EmergencyPhoneNumber;
            existingTicketBooking.Gender = request.Gender ?? request.Gender;
            existingTicketBooking.LastName = request.LastName ?? existingTicketBooking.LastName;
            existingTicketBooking.Passport = request.Passport ?? existingTicketBooking.Passport;
            existingTicketBooking.PhoneNumber = request.PhoneNumber ?? existingTicketBooking.PhoneNumber;
            existingTicketBooking.TicketStatus = request.TicketStatus ?? existingTicketBooking.TicketStatus;
            existingTicketBooking.IsInternational = request.IsInternational ?? existingTicketBooking.IsInternational;
            await _ticketBookingRepository.UpdateAsync(existingTicketBooking);
            await _ticketBookingRepository.SaveChangesAsync();
        }
    }
}