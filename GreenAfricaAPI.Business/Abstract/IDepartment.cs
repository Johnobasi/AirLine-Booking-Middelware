using GreenAfrica.DataAccess.Models;
using System.Collections.Generic;

namespace GreenAfricaAPI.Business.Abstract
{
    public interface IDepartment
    {
        IEnumerable<Department> GetAll();
    }
}
