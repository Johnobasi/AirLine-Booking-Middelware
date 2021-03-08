using GreenAfrica.DataAccess.Models;
using System.Collections.Generic;

namespace GreenAfricaAPI.Business.Abstract
{
    public interface IPilot
    {
        IEnumerable<Pilot> GetPilot();
        Pilot GetById(int Id);
    }
}
