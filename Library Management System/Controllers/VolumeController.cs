using Library_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolumeController: ControllerBase
    {
        private readonly LmsDatabaseContext _dbcontext;

        public VolumeController(Library_Management_System.Models.LmsDatabaseContext dbContext)
        {
            _dbcontext = dbContext;
        }
        [HttpGet]
        public ActionResult Result()
        {
            return Ok(new VolumeInfo());
        }
    }
}
