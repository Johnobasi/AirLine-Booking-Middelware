using GreenAfrica.DataAccess.Models;
using System.Collections.Generic;

namespace GreenAfricaAPI.Business.Abstract
{
    public interface ICPayroll
    {
        IEnumerable<CPayroll> GetAll();
    }

}
