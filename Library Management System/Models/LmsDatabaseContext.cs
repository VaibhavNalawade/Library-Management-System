using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class LmsDatabaseContext : DbContext
    {
        public LmsDatabaseContext(DbContextOptions<LmsDatabaseContext> options)
       : base(options)
        { }
      
        public DbSet<Member> members { get; set; }
        public DbSet<VolumeInfo>volumes { get; set; }
    }
}