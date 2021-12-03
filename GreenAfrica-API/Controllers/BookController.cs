using GreenAfrica.DataAccess.Models;
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
    public class BookController : ControllerBase
    {
        private readonly IBook _bookRepository;

        public BookController(IBook bookRepository)
        {
            _bookRepository = bookRepository;
        }


    }
}
