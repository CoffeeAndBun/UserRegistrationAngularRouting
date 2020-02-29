using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Entities;

namespace WebApi.Models
{
    public class CnBContext : IdentityDbContext
    {
        public CnBContext(DbContextOptions<CnBContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> applicationUsers { get; set; }
    }
}
