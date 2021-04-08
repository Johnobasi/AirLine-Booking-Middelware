using GreenAfricaAPI.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenAfrica_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment _department;

        public DepartmentController(IDepartment department)
        {
            _department = department;
        }

        public ActionResult GetAll()
        {
            var dept = _department.GetAll();
            return Ok(dept);
        }
    }
}
