using GreenAfrica.DataAccess;
using GreenAfrica.DataAccess.Models;
using GreenAfricaAPI.Business.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenAfricaAPI.Business
{
    public class TicketService : ITickets
    {
        private readonly GreenAPIDbContext _context;

        public TicketService(GreenAPIDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Tickets> GetAllTickets()
        {
            return _context.Tickets;
        }

        public Tickets GetTicketById(int Id)
        {
            return _context.Tickets.Where(c => c.Id == Id).FirstOrDefault();
        }
    }
}
