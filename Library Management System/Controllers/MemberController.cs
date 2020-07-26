using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_Management_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly LmsDatabaseContext _dbcontext;

        public MemberController(LmsDatabaseContext  dbContext)
        {
            _dbcontext = dbContext;  
        }
        [HttpGet]
       public ActionResult Result()
        {
            return Ok(new Member());
        }
        [HttpPost("Create")]
        public ActionResult Result(Member mbox)
        {
          
            _dbcontext.members.Add(mbox);
            _dbcontext.SaveChanges();
            return Ok(mbox);
        }
    }
}