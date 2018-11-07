using System;
using System.Collections.Generic;
using System.Linq;
using ExpressReturnAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpressReturnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturnController : ControllerBase
    {
        private readonly ReturnHeadDbContext _context;

        public ReturnController(ReturnHeadDbContext context)
        {
            _context = context;
        }
        // GET api/value
        [HttpGet]
        [Produces("application/json")]
        public ActionResult<List<ReturnHead>> Get()
        {
            var returns = _context.ReturnHeadDTOs
                .Include(u => u.Customer)
                .Include(u=>u.Lines)
                .ToList();
            return returns;
        }
    }
}
