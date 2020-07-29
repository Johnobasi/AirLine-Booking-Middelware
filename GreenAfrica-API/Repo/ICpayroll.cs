using GreenAfrica_API.Data;
using System;
using System.Collections.Generic;

namespace GreenAfrica_API.Repo
{
    public interface ICpayroll
    {
        IEnumerable<Cpayroll> GetAll();
        IEnumerable<FlightInfo> GetById(string flightNumber);
        IEnumerable<Cpayroll> GetByFlightDate(DateTime startDate, DateTime endDate);

    }
}
