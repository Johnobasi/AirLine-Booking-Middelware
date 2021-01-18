using GreenAfrica.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenAfricaAPI.Business.Abstract
{
    public interface ITickets
    {
        IEnumerable<Tickets> GetAllTickets();
        Tickets GetTicketById(int Id);
    }
}
