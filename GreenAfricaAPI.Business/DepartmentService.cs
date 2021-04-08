using GreenAfrica.DataAccess;
using GreenAfrica.DataAccess.Models;
using GreenAfricaAPI.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenAfricaAPI.Business
{
    public class DepartmentService : IDepartment
    {
        private readonly GreenAPIDbContext _dbContext;

        public DepartmentService(GreenAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Department> GetAll()
        {
            return _dbContext.Departments;
        }
    }
}
