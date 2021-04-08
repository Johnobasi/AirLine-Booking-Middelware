using GreenAfrica.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenAfricaAPI.Business.Abstract
{
    public interface IFleet
    {
        IEnumerable<Fleet> GetAll();
        Fleet GetById(int Id);
    }
}
